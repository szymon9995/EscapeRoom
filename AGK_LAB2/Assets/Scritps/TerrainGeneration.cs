using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TerrainGeneration : MonoBehaviour
{

    private Mesh mesh = null;
    private Vector3[] verticies = null;
    private int[] triangles = null;

    public int width = 64;
    public int height = 64;
    public float scale = 2.0f;

    public Gradient gradient = new Gradient();
    Color[] uvs = null;
    float minTerrain = int.MaxValue;
    float maxTerrain = int.MinValue;


    void Start()
    {
        mesh = new Mesh();
        GetComponent<MeshFilter>().mesh = mesh;
        CreateMesh();
        DrawMesh();
    }

    private void Update()
    {
        DrawMesh();
    }

    void CreateMesh()
    {
        verticies = new Vector3[(width + 1) * (height + 1)];

        int i = 0;
        for(int z=0; z<=height; z++)
        {
            for(int x=0; x<=width; x++)
            {
                float y = Mathf.PerlinNoise(x * 0.3f,z * 0.3f) * scale;
                verticies[i] = new Vector3(x,y,z);
                if(maxTerrain < y)
                {
                    maxTerrain = y;
                }
                if(minTerrain > y)
                {
                    minTerrain = y;
                }
                //Debug.Log(verticies[i]);
                i++;
            }
        }

        triangles = new int[width * height * 6];

        int tris = 0;
        int vert = 0;
        for (int z = 0; z < height; z++)
        {
            for (int x = 0; x < width; x++)
            {
                triangles[tris + 0] = vert + 0;
                triangles[tris + 1] = vert + width + 1;
                triangles[tris + 2] = vert + 1;
                triangles[tris + 3] = vert + 1;
                triangles[tris + 4] = vert + width + 1;
                triangles[tris + 5] = vert + width + 2;

                vert++;
                tris += 6;
            }
            vert++;
        }

        uvs = new Color[verticies.Length];

        i = 0;
        for (int z = 0; z <= height; z++)
        {
            for (int x = 0; x <= width; x++)
            {
                float y = Mathf.InverseLerp(minTerrain,maxTerrain,verticies[i].y);
                uvs[i] = gradient.Evaluate(y);
                i++;
            }
        }

    }
    void DrawMesh()
    {
        mesh.Clear();

        mesh.vertices = verticies;
        mesh.triangles = triangles;
        mesh.colors = uvs;

        mesh.RecalculateNormals();
    }


}
