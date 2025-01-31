using System.Collections.Generic;
using UnityEngine;

[ExecuteAlways]
public class WaypointGenerator : MonoBehaviour
{
    public Transform waypointPrefab; // Assign a prefab with a marker in the Inspector
    public Terrain terrain; // Assign the terrain object in the Inspector
    public List<Transform> waypoints;

    public float gizmoSize = 1.0f;
    public Color gizmoColor = Color.red;

    public void AddWaypoint(Vector3 position)
    {
        if (waypointPrefab != null)
        {
            Transform waypoint = Instantiate(waypointPrefab, position, Quaternion.identity, transform);
            waypoints.Add(waypoint);
            Debug.Log($"Waypoint added at {position}");
        }
        else
        {
            Debug.LogWarning("Waypoint prefab is not assigned!");
        }
    }

    private void OnDrawGizmos() {
        Gizmos.color = gizmoColor;
        foreach ( var waypoint in waypoints ) {
            if(waypoint != null) {
                Gizmos.DrawSphere(waypoint.position, gizmoSize);
            }
        }

        for(int i = 0; i < waypoints.Count - 1; i++) {
            if(waypoints[i] != null && waypoints[i + 1] != null) {
                Gizmos.DrawLine(waypoints[i].position, waypoints[i + 1].position);
            }
        }
    }
}
