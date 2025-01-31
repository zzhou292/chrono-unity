#if UNITY_EDITOR
using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(WaypointGenerator))]
public class WaypointEditor : Editor
{
    private WaypointGenerator generator;
    private bool isAddingWaypoints = false;

    private void OnEnable()
    {
        generator = (WaypointGenerator)target;
    }

    public override void OnInspectorGUI()
    {
        DrawDefaultInspector();

        if (GUILayout.Button("Add Waypoint"))
        {
            isAddingWaypoints = !isAddingWaypoints;
            SceneView.duringSceneGui += OnSceneGUI;
            Debug.Log(isAddingWaypoints ? "Click on terrain to add waypoints." : "Stopped adding waypoints.");
        }

        if (!isAddingWaypoints)
        {
            SceneView.duringSceneGui -= OnSceneGUI;
        }
    }

    private void OnSceneGUI(SceneView sceneView)
    {
        if (Event.current.type == EventType.MouseDown && Event.current.button == 0 && isAddingWaypoints)
        {
            Ray ray = HandleUtility.GUIPointToWorldRay(Event.current.mousePosition);
            if (Physics.Raycast(ray, out RaycastHit hit))

            {
                if (hit.collider.gameObject == generator.terrain.gameObject)
                {
                    generator.AddWaypoint(hit.point);
                    Event.current.Use();
                }
            }
        }
    }
}
#endif