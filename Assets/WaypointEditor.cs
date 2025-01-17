using UnityEngine;
using UnityEditor;
using System.Collections.Generic;

[ExecuteInEditMode]
public class WaypointEditor : MonoBehaviour
{
    public List<Transform> waypoints = new List<Transform>();
    public Color lineColor = Color.green;
    public float sphereSize = 0.5f;

    public GameObject firstWaypointReference;

    public void OnDrawGizmos()
    {
        Gizmos.color = lineColor;

        if (waypoints == null || waypoints.Count < 2)
            return;

        for (int i = 0; i < waypoints.Count; i++)
        {
            if (waypoints[i] != null)
            {
                Gizmos.DrawSphere(waypoints[i].position, sphereSize);

                if (i > 0 && waypoints[i - 1] != null)
                {
                    Gizmos.DrawLine(waypoints[i - 1].position, waypoints[i].position);
                }
            }
        }
    }
}


[CustomEditor(typeof(WaypointEditor))]
public class WaypointEditorInspector : Editor
{

    public override void OnInspectorGUI()
    {
        WaypointEditor script = (WaypointEditor)target;

        script.lineColor = EditorGUILayout.ColorField("Line Color", script.lineColor);
        script.sphereSize = EditorGUILayout.FloatField("Sphere Size", script.sphereSize);
        script.firstWaypointReference = (GameObject)EditorGUILayout.ObjectField("First Waypoint Reference GameObject", script.firstWaypointReference, typeof(GameObject), true);

        if (GUILayout.Button("Add Waypoint"))
        {
            GameObject waypoint = new GameObject("Waypoint " + script.waypoints.Count);

            if (script.waypoints.Count > 0 && script.waypoints[script.waypoints.Count - 1] != null)
            {
                Vector3 newPosition = script.waypoints[script.waypoints.Count - 1].position + Vector3.right;
                if (Physics.Raycast(newPosition + Vector3.up * 10, Vector3.down, out RaycastHit hit))
                {
                    newPosition.y = hit.point.y;
                }
                waypoint.transform.position = newPosition;
            }
            else
            {
                Vector3 newPosition = script.firstWaypointReference.transform.position;
                // Vector3 newPosition = Vector3.zero;
                if (Physics.Raycast(newPosition + Vector3.up * 10, Vector3.down, out RaycastHit hit))
                {
                    newPosition.y = hit.point.y;
                }
                waypoint.transform.position = newPosition;
            }

            waypoint.transform.parent = script.transform;
            var waypointScript = waypoint.AddComponent<Waypoint>();
            waypointScript.AdjustHeightToTerrain();
            script.waypoints.Add(waypoint.transform);
        }

        if (GUILayout.Button("Clear Waypoints"))
        {
            if (EditorUtility.DisplayDialog("Clear Waypoints", "Are you sure you want to delete all waypoints?", "Yes", "No"))
            {
                foreach (var wp in script.waypoints)
                {
                    if (wp != null)
                        DestroyImmediate(wp.gameObject);
                }
                script.waypoints.Clear();
            }
        }

        if (GUILayout.Button("Adjust Heights"))
        {
            foreach (var wp in script.waypoints)
            {
                if (wp != null)
                {
                    var waypointScript = wp.GetComponent<Waypoint>();
                    if (waypointScript != null)
                    {
                        waypointScript.AdjustHeightToTerrain();
                    }
                }
            }
        }

        if (GUI.changed)
        {
            EditorUtility.SetDirty(target);
        }
    }
}
