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

    private UdpClient udpClient;
    private Thread receiveThread;
    private volatile float steeringInput = 0f;
    private volatile float throttleInput = 0f;
    private volatile float brakingInput = 0f;

    void Start()
    {
        UChSystem system = (UChSystem)FindObjectOfType(typeof(UChSystem));
        system.Register(gameObject.name + "_driver", this);

        // Initialize UDP client and start listening thread
        udpClient = new UdpClient(1209);
        receiveThread = new Thread(new ThreadStart(ReceiveData));
        receiveThread.IsBackground = true;
        receiveThread.Start();
    }

    private void ReceiveData()
    {
        IPEndPoint anyIP = new IPEndPoint(IPAddress.Any, 0);
        while (true)
        {
            try
            {
                byte[] data = udpClient.Receive(ref anyIP);
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

        if (udpClient != null)
            udpClient.Close();
    }
}

