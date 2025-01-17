using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaypointDriver : MonoBehaviour, IAdvance
{    
    public UChVehicle vehicle;  // associated vehicle
    public WaypointEditor waypoint_editor;
    private List<Transform> waypoints;

    public float kp = 1.0f; // Proportional gain for steering
    public float ki = 0.0f; // Integral gain for steering
    public float kd = 0.1f; // Derivative gain for steering

    public float speedKp = 0.5f; // Proportional gain for speed control

    private float integralTerm = 0.0f; // Integral error for steering
    private float previousError = 0.0f; // Previous error for steering

    private int currentWaypointIndex = 0; // Current target waypoint index

    public float desiredSpeed = 10.0f; // Desired vehicle speed (in m/s)


    private bool hasStarted = false; // Flag to check if the vehicle has started
    private float startDelay = 5.0f; // Delay in seconds before starting
    private float timer = 0.0f; // Timer to track elapsed time


    // Start is called before the first frame update
    void Start()
    {
        // Register with the Chrono system (for Advance).
        UChSystem system = (UChSystem)FindObjectOfType(typeof(UChSystem));
        system.Register(gameObject.name + "_driver", this);

        waypoints = waypoint_editor.waypoints;
    }

    // Update is called once per frame
    public void Advance(double step)
    {

        if (!hasStarted)
        {
            // Increment the timer until the start delay has elapsed
            timer += (float)step;
            if (timer >= startDelay)
            {
                hasStarted = true;
            }
            else
            {
                // Ensure the vehicle remains stationary during the delay
                vehicle.SetDriverInputs(0.0f, 0.0f, 1.0f); // No steering, no throttle, full brake
                return;
            }
        }

        if (waypoints.Count == 0) return;

        // Get the current target waypoint
        Transform targetWaypoint = waypoints[currentWaypointIndex];

        // Calculate the direction to the target waypoint
        Vector3 vehiclePosition = vehicle.transform.position;
        Vector3 directionToWaypoint = (targetWaypoint.position - vehiclePosition).normalized;

        // Debug draw the direction to the waypoint
        Debug.DrawLine(vehiclePosition, targetWaypoint.position, Color.red, 0.1f);

        // Get the vehicle's forward direction
        Vector3 vehicleForward = vehicle.transform.right;

        // Calculate the angle error between the vehicle's forward direction and the target direction
        float angleError = Vector3.SignedAngle(vehicleForward, directionToWaypoint, Vector3.up);

        Debug.Log(angleError);
        
        if (Mathf.Abs(angleError) > 180) {
            currentWaypointIndex = (currentWaypointIndex + 1) % waypoints.Count; // Move to the next waypoint (loop around)
        }

        // PID calculations for steering
        integralTerm += angleError * (float)step; // Accumulate integral error
        float derivativeTerm = (angleError - previousError) / (float)step; // Calculate derivative error
        previousError = angleError; // Update the previous error

        // Compute the steering value using PID formula
        float steering = kp * angleError + ki * integralTerm + kd * derivativeTerm;

        // Clamp the steering value to the valid range (-1.0 to 1.0, depending on the vehicle's requirements)
        steering = -Mathf.Clamp(steering, -0.5f, 0.5f);

        // Longitudinal speed control
        float currentSpeed = (float)vehicle.GetSpeed(); // Assume GetSpeed() returns the current speed in m/s
        float speedError = desiredSpeed - currentSpeed;

        // Compute throttle or brake based on speed error
        float throttle = Mathf.Clamp(speedKp * speedError, 0.0f, 1.0f);
        float brake = Mathf.Clamp(-speedKp * speedError, 0.0f, 1.0f);

        // Update the vehicle's inputs (steering, throttle, braking)
        vehicle.SetDriverInputs(steering, throttle, brake);

        // Check if the vehicle is close enough to the target waypoint to switch to the next one
        float distanceToWaypoint = Vector3.Distance(vehiclePosition, targetWaypoint.position);
        if (distanceToWaypoint < 2.0f) // Adjust this threshold as needed
        {
            currentWaypointIndex = (currentWaypointIndex + 1) % waypoints.Count; // Move to the next waypoint (loop around)
        }
    }
}
