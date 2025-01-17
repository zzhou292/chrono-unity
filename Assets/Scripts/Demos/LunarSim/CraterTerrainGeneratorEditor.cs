using UnityEditor;
using UnityEngine;

[CustomEditor(typeof(CraterTerrainGenerator))]
public class CraterTerrainGeneratorEditor : Editor
{
    public override void OnInspectorGUI()
    {
        DrawDefaultInspector();

        CraterTerrainGenerator terrainScript = (CraterTerrainGenerator)target;

        if (GUILayout.Button("Generate Terrain"))
        {
            terrainScript.GenerateTerrainInEditor();
        }
    }
}
