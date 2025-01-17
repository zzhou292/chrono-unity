using UnityEngine;

[RequireComponent(typeof(Terrain))]
public class CraterTerrainGenerator : MonoBehaviour
{
    [Header("Terrain Settings")]
    public int terrainWidth = 512;
    public int terrainHeight = 512;
    public int terrainDepth = 50;

    [Header("Perlin Noise Settings")]
    public float scale = 20f;
    public float offsetX = 100f;
    public float offsetY = 100f;

    [Header("Crater Settings")]
    public int numberOfCraters = 10;
    public float minCraterRadius = 10f;
    public float maxCraterRadius = 30f;
    public float rimHeightFactor = 0.1f; // Proportion of crater radius for rim height

    private Terrain terrain;

    public void GenerateTerrainInEditor()
    {
        terrain = GetComponent<Terrain>();
        terrain.terrainData = GenerateTerrain(terrain.terrainData);
    }

    TerrainData GenerateTerrain(TerrainData terrainData)
    {
        terrainData.heightmapResolution = terrainWidth + 1;
        terrainData.size = new Vector3(terrainWidth, terrainDepth, terrainHeight);
        float[,] heights = GenerateHeights();
        heights = AddCraters(heights);
        terrainData.SetHeights(0, 0, heights);
        return terrainData;
    }

    float[,] GenerateHeights()
    {
        float[,] heights = new float[terrainWidth, terrainHeight];
        for (int x = 0; x < terrainWidth; x++)
        {
            for (int y = 0; y < terrainHeight; y++)
            {
                heights[x, y] = CalculateHeight(x, y);
            }
        }
        return heights;
    }

    float CalculateHeight(int x, int y)
    {
        float xCoord = (float)x / terrainWidth * scale + offsetX;
        float yCoord = (float)y / terrainHeight * scale + offsetY;
        return Mathf.PerlinNoise(xCoord, yCoord);
    }

    float[,] AddCraters(float[,] heights)
    {
        for (int i = 0; i < numberOfCraters; i++)
        {
            int craterX = Random.Range(0, terrainWidth);
            int craterY = Random.Range(0, terrainHeight);
            float craterRadius = Mathf.Pow(Random.Range(Mathf.Pow(minCraterRadius, 2), Mathf.Pow(maxCraterRadius, 2)), 0.5f);
            float craterDepth = craterRadius * 0.5f; // Depth proportional to radius
            float rimHeight = craterRadius * rimHeightFactor;

            for (int x = 0; x < terrainWidth; x++)
            {
                for (int y = 0; y < terrainHeight; y++)
                {
                    float distance = Vector2.Distance(new Vector2(x, y), new Vector2(craterX, craterY));
                    float normalizedDistance = distance / craterRadius;

                    if (distance < craterRadius)
                    {
                        // Smoothen the crater floor by applying an improved curve
                        float depth = craterDepth * (1 - Mathf.Pow(normalizedDistance, 3)) * (1 - normalizedDistance); // Cubic curve with flattening
                        heights[x, y] -= depth / terrainDepth;
                    }
                    else if (distance < craterRadius * 1.1f)
                    {
                        // Add a raised rim around the crater
                        float rimEffect = Mathf.Lerp(rimHeight, 0, (distance - craterRadius) / (craterRadius * 0.2f));
                        heights[x, y] += rimEffect / terrainDepth;
                    }
                }
            }
        }
        return heights;
    }
}
