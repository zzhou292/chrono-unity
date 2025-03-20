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


    // Constants defined using Chrono's PI constant
    public static ChVector3d driver_eyepoint = new ChVector3d(-0.3, 0.4, 0.98);
    public static readonly float RADS_2_RPM = 30.0f / (float)chrono.CH_PI;
    public static readonly float RADS_2_DEG = 180.0f / (float)chrono.CH_PI;
    public const float MS_2_MPH = 2.2369f;
    public const float M_2_FT = 3.28084f;
    public const float G_2_MPSS = 9.81f;

    private UdpClient udpRecvClient;
    private UdpClient udpSendClient;
    private Thread receiveThread;
    private Thread sendThread;
    private volatile float steeringInput = 0f;
    private volatile float throttleInput = 0f;
    private volatile float brakingInput = 0f;


    private ChRunningAverage acc_x = new ChRunningAverage(100);
    private ChRunningAverage acc_y = new ChRunningAverage(100);
    private ChRunningAverage acc_z = new ChRunningAverage(100);

    private ChRunningAverage ang_vel_x = new ChRunningAverage(100);
    private ChRunningAverage ang_vel_y = new ChRunningAverage(100);
    private ChRunningAverage ang_vel_z = new ChRunningAverage(100);

    private ChRunningAverage eyepoint_vel_x = new ChRunningAverage(100);
    private ChRunningAverage eyepoint_vel_y = new ChRunningAverage(100);
    private ChRunningAverage eyepoint_vel_z = new ChRunningAverage(100);

    private ChRunningAverage eyepoint_acc_x = new ChRunningAverage(100);
    private ChRunningAverage eyepoint_acc_y = new ChRunningAverage(100);
    private ChRunningAverage eyepoint_acc_z = new ChRunningAverage(100);

    private ChRunningAverage lf_wheel_vel = new ChRunningAverage(100);
    private ChRunningAverage rf_wheel_vel = new ChRunningAverage(100);
    private ChRunningAverage lr_wheel_vel = new ChRunningAverage(100);
    private ChRunningAverage rr_wheel_vel = new ChRunningAverage(100);


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

        // Total size (37 floats)
        const int totalSize = floatSize * 37;

        while (true)
        {
            try
            {
                // index 0: simTime
                float simTime =(float)vehicle.GetChVehicle().GetSystem().GetChTime();


                // index 1,2,3: chassis location
                float chassis_x = (float)(vehicle.GetChVehicle().GetPos().x * M_2_FT);
                float chassis_y = (float)(-vehicle.GetChVehicle().GetPos().y * M_2_FT);
                float chassis_z = (float)(-vehicle.GetChVehicle().GetPos().z * M_2_FT);

                // index 4,5,6: eye point location
                float eyepoint_x = (float)(-vehicle.GetChVehicle().GetPos().y * M_2_FT);
                float eyepoint_y = (float)(vehicle.GetChVehicle().GetPos().x * M_2_FT);
                float eyepoint_z = (float)(vehicle.GetChVehicle().GetPos().z * M_2_FT);

                // index 7,8,9: Eyepoint/Chassis orientation
                ChQuaterniond chassisRot = vehicle.GetChVehicle().GetRot();
                Quaternion unityRot = Utils.FromChrono(chassisRot);
                Vector3 eulerAngles = unityRot.eulerAngles;

                float chassis_rot_x = eulerAngles.z * (float)RADS_2_DEG;
                float chassis_rot_y = -eulerAngles.y * (float)RADS_2_DEG;
                float chassis_rot_z = eulerAngles.x * (float)RADS_2_DEG;

                // index 10,11,12: Chassis angular velocity
                Vector3 ang_vel = vehicle.GetWvelLocal();
                float ang_vel_x_filtered = (float)ang_vel_x.Add(ang_vel.x);
                float ang_vel_y_filtered = -(float)ang_vel_y.Add(ang_vel.y);
                float ang_vel_z_filtered = -(float)ang_vel_z.Add(ang_vel.z);

                // index 13,14,15: Chassis velocity
                ChVector3d chassis_velocity = vehicle.GetChVehicle().GetPointVelocity(new ChVector3d(0, 0, 0));
                float chassis_vel_x = (float)(chassis_velocity.x * M_2_FT);
                float chassis_vel_y = (float)(-chassis_velocity.y * M_2_FT); 
                float chassis_vel_z = (float)(-chassis_velocity.z * M_2_FT);


                // index 16,17,18: Eyepoint velocity
                ChVector3d eyepoint_velocity = vehicle.GetChVehicle().GetPointVelocity(driver_eyepoint);
                float eyepoint_velocity_x_filtered = (float)eyepoint_vel_x.Add(eyepoint_velocity.x)*M_2_FT;
                float eyepoint_velocity_y_filtered = (float)eyepoint_vel_y.Add(-eyepoint_velocity.y)*M_2_FT;
                float eyepoint_velocity_z_filtered = (float)eyepoint_vel_z.Add(-eyepoint_velocity.z)*M_2_FT;

                // index 19,20,21: Chassis local acceleration
                ChVector3d chassis_acceleration = vehicle.GetChVehicle().GetPointAcceleration(vehicle.GetChVehicle().GetChassis().GetCOMFrame().GetPos());
                float acc_loc_x_filtered = (float)acc_x.Add(chassis_acceleration.x) * M_2_FT;
                float acc_loc_y_filtered = (float)acc_y.Add(-chassis_acceleration.y) * M_2_FT;
                float acc_loc_z_filtered = (float)acc_z.Add(-chassis_acceleration.z) * M_2_FT;

                // index 22,23,24: eyepoint specific force
                // Get acceleration at eyepoint
                ChVector3d eyepoint_acceleration = vehicle.GetChVehicle().GetPointAcceleration(driver_eyepoint);

                // Get chassis orientation quaternion
                ChQuaterniond chassisRotQuat = vehicle.GetChVehicle().GetRot();

                // Define gravity vector in global frame
                ChVector3d gravity = new ChVector3d(0.0, 0.0, -9.81);

                // Transform gravity to local frame using quaternion rotation
                // First convert to the Unity equivalent for calculations
                Quaternion unityChassisRot = Utils.FromChrono(chassisRotQuat);
                Vector3 unityGravity = new Vector3(0, 0, -9.81f);
                Vector3 localGravity = Quaternion.Inverse(unityChassisRot) * unityGravity;

                // Convert back to Chrono vector
                ChVector3d local_g = new ChVector3d(localGravity.x, localGravity.y, localGravity.z);

                // Calculate specific force (acceleration + gravity in local frame)
                float eye_acc_x_filtered = ((float)eyepoint_acc_x.Add((eyepoint_acceleration.x + local_g.x)/G_2_MPSS));
                float eye_acc_y_filtered = ((float)eyepoint_acc_y.Add((-eyepoint_acceleration.y + local_g.y)/G_2_MPSS));
                float eye_acc_z_filtered = ((float)eyepoint_acc_z.Add((-eyepoint_acceleration.z + local_g.z)/G_2_MPSS));

                // index 25,26,27,28,29,30,31,32: wheel center positions
                // WheelState wheel_LF_state = vehicle.GetChVehicle().GetWheel(0, VehicleSide.LEFT).GetState();
                // WheelState wheel_RF_state = vehicle.GetChVehicle().GetWheel(0, VehicleSide.RIGHT).GetState();
                // WheelState wheel_LR_state = vehicle.GetChVehicle().GetWheel(1, VehicleSide.LEFT).GetState();
                // WheelState wheel_RR_state = vehicle.GetChVehicle().GetWheel(1, VehicleSide.RIGHT).GetState();
                // WheelState wheel_LF_state = vehicle.GetChVehicle().GetAxle(0).m_wheels[0].GetState();

                float wheel_RF_pos_x = (float)(0.0);  // 25 - RF wheel center pos x - global
                float wheel_RF_pos_y = (float)(0.0);  // 26 - RF wheel center pos y - global
                float wheel_LF_pos_x = (float)(0.0);  // 27 - LF wheel center pos x - global
                float wheel_LF_pos_y = (float)(0.0);  // 28 - LF wheel center pos y - global
                float wheel_RR_pos_x = (float)(0.0);  // 29 - RR wheel center pos x - global
                float wheel_RR_pos_y = (float)(0.0);  // 30 - RR wheel center pos y - global
                float wheel_LR_pos_x = (float)(0.0);  // 31 - LR wheel center pos x - global
                float wheel_LR_pos_y = (float)(0.0);  // 32 - LR wheel center pos y - global

                // // index 33,34,35,36: wheel rotation velocities
                float lf_omega_filtered = (float)lf_wheel_vel.Add(0.0);  // 33 
                float rf_omega_filtered = (float)rf_wheel_vel.Add(0.0);  // 34 
                float lr_omega_filtered = (float)lr_wheel_vel.Add(0.0);  // 35
                float rr_omega_filtered = (float)rr_wheel_vel.Add(0.0);  // 36

                byte[] data = new byte[totalSize];

                // Fill the data array at explicit offsets
                Buffer.BlockCopy(BitConverter.GetBytes(simTime),   0, data, 0, floatSize);  // 0
                Buffer.BlockCopy(BitConverter.GetBytes(chassis_x),     0, data, 4, floatSize);  // 1
                Buffer.BlockCopy(BitConverter.GetBytes(chassis_y),0, data, 8, floatSize);  // 2
                Buffer.BlockCopy(BitConverter.GetBytes(chassis_z),0, data, 12, floatSize);  // 3    
                Buffer.BlockCopy(BitConverter.GetBytes(eyepoint_x),0, data, 16, floatSize);  // 4
                Buffer.BlockCopy(BitConverter.GetBytes(eyepoint_y),0, data, 20, floatSize);  // 5
                Buffer.BlockCopy(BitConverter.GetBytes(eyepoint_z),0, data, 24, floatSize);  // 6
                Buffer.BlockCopy(BitConverter.GetBytes(chassis_rot_x),0, data, 28, floatSize);  // 7
                Buffer.BlockCopy(BitConverter.GetBytes(chassis_rot_y),0, data, 32, floatSize);  // 8
                Buffer.BlockCopy(BitConverter.GetBytes(chassis_rot_z),0, data, 36, floatSize);  // 9
                Buffer.BlockCopy(BitConverter.GetBytes(ang_vel_x_filtered),0, data, 40, floatSize);  // 10
                Buffer.BlockCopy(BitConverter.GetBytes(ang_vel_y_filtered),0, data, 44, floatSize);  // 11
                Buffer.BlockCopy(BitConverter.GetBytes(ang_vel_z_filtered),0, data, 48, floatSize);  // 12
                Buffer.BlockCopy(BitConverter.GetBytes(chassis_vel_x),0, data, 52, floatSize);  // 13
                Buffer.BlockCopy(BitConverter.GetBytes(chassis_vel_y),0, data, 56, floatSize);  // 14
                Buffer.BlockCopy(BitConverter.GetBytes(chassis_vel_z),0, data, 60, floatSize);  // 15
                Buffer.BlockCopy(BitConverter.GetBytes(eyepoint_velocity_x_filtered),0, data, 64, floatSize);  // 16
                Buffer.BlockCopy(BitConverter.GetBytes(eyepoint_velocity_y_filtered),0, data, 68, floatSize);  // 17
                Buffer.BlockCopy(BitConverter.GetBytes(eyepoint_velocity_z_filtered),0, data, 72, floatSize);  // 18
                Buffer.BlockCopy(BitConverter.GetBytes(acc_loc_x_filtered),0, data, 76, floatSize);  // 19
                Buffer.BlockCopy(BitConverter.GetBytes(acc_loc_y_filtered),0, data, 80, floatSize);  // 20
                Buffer.BlockCopy(BitConverter.GetBytes(acc_loc_z_filtered),0, data, 84, floatSize);  // 21
                Buffer.BlockCopy(BitConverter.GetBytes(eye_acc_x_filtered),0, data, 88, floatSize);  // 22
                Buffer.BlockCopy(BitConverter.GetBytes(eye_acc_y_filtered),0, data, 92, floatSize);  // 23
                Buffer.BlockCopy(BitConverter.GetBytes(eye_acc_z_filtered),0, data, 96, floatSize);  // 24
                // Buffer.BlockCopy(BitConverter.GetBytes(wheel_RF_pos_x), 0, data, 100, floatSize);  // 25
                // Buffer.BlockCopy(BitConverter.GetBytes(wheel_RF_pos_y), 0, data, 104, floatSize);  // 26
                // Buffer.BlockCopy(BitConverter.GetBytes(wheel_LF_pos_x), 0, data, 108, floatSize);  // 27
                // Buffer.BlockCopy(BitConverter.GetBytes(wheel_LF_pos_y), 0, data, 112, floatSize);  // 28
                // Buffer.BlockCopy(BitConverter.GetBytes(wheel_RR_pos_x), 0, data, 116, floatSize);  // 29
                // Buffer.BlockCopy(BitConverter.GetBytes(wheel_RR_pos_y), 0, data, 120, floatSize);  // 30
                // Buffer.BlockCopy(BitConverter.GetBytes(wheel_LR_pos_x), 0, data, 124, floatSize);  // 31
                // Buffer.BlockCopy(BitConverter.GetBytes(wheel_LR_pos_y), 0, data, 128, floatSize);  // 32
                

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

