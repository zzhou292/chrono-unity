using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using System;

public class WaypointDriver : MonoBehaviour, IAdvance
{
    public UChVehicle vehicle;  // associated vehicle
    public WaypointGenerator waypoint_editor;

    private UdpClient udpRecvClient;
    private UdpClient udpSendClient;
    private Thread receiveThread;
    private Thread sendThread;
    private volatile float steeringInput = 0f;
    private volatile float throttleInput = 0f;
    private volatile float brakingInput = 0f;


    void Start()
    {
        UChSystem system = (UChSystem)FindObjectOfType(typeof(UChSystem));
        system.Register(gameObject.name + "_driver", this);

        // Initialize UDP client and start listening thread
        udpRecvClient = new UdpClient(1209);
        receiveThread = new Thread(new ThreadStart(ReceiveData));
        receiveThread.IsBackground = true;
        receiveThread.Start();

        // Initialize UDP client for sending data
        udpSendClient = new UdpClient();
        sendThread = new Thread(new ThreadStart(SendData));
        sendThread.IsBackground = true;
        sendThread.Start();
    }

    private void SendData()
    {
        IPEndPoint remoteEndPoint = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 1210);

        // Each float is 4 bytes
        const int floatSize = sizeof(float);

        // Total size (5 floats)
        const int totalSize = floatSize * 5;                  // 20 bytes total

        while (true)
        {
            try
            {
                float simTime =(float)vehicle.GetChVehicle().GetSystem().GetChTime();
                float speed = (float)(vehicle.GetSpeed());
                ChVector3d position = vehicle.GetChVehicle().GetPos();
                

                byte[] data = new byte[totalSize];

                // Fill the data array at explicit offsets
                Buffer.BlockCopy(BitConverter.GetBytes(simTime),   0, data, 0, floatSize);
                Buffer.BlockCopy(BitConverter.GetBytes(speed),     0, data, 4, floatSize);
                Buffer.BlockCopy(BitConverter.GetBytes((float)position.x),0, data, 8, floatSize);
                Buffer.BlockCopy(BitConverter.GetBytes((float)position.y),0, data, 12, floatSize);
                Buffer.BlockCopy(BitConverter.GetBytes((float)position.z),0, data, 16, floatSize);

                udpSendClient.Send(data, data.Length, remoteEndPoint);

                Thread.Sleep(10); // Optional delay (100 packets per second)
            }
            catch (Exception err)
            {
                Debug.LogError(err.ToString());
            }
        }
    }

    private void ReceiveData()
    {
        IPEndPoint anyIP = new IPEndPoint(IPAddress.Any, 0);
        while (true)
        {
            try
            {
                byte[] data = udpRecvClient.Receive(ref anyIP); // <-- use udpRecvClient here
                if (data.Length == sizeof(float) * 3)
                {
                    steeringInput = BitConverter.ToSingle(data, 0);
                    throttleInput = BitConverter.ToSingle(data, 4);
                    brakingInput = BitConverter.ToSingle(data, 8);
                }
            }
            catch (Exception err)
            {
                Debug.LogError(err.ToString());
            }
        }
    }


    public void Advance(double step)
    {
        throttleInput = 0.1f * throttleInput;
        brakingInput = 0.2f * brakingInput;
        vehicle.SetDriverInputs(steeringInput, throttleInput, brakingInput);
    }

    void OnApplicationQuit()
    {
        if (receiveThread != null)
            receiveThread.Abort();

        if (sendThread != null)
            sendThread.Abort();

        if (udpRecvClient != null)
            udpRecvClient.Close();

        if (udpSendClient != null)
            udpSendClient.Close();
    }

}

