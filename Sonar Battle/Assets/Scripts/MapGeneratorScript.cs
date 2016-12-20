using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapGeneratorScript : MonoBehaviour {

	public int Seed = 12345;
    public bool useRandomSeed;
    [Range(0,100)]
	public int Filledness = 10;
    [Range(0, 20)]
    public int Smoothness;
	public int MapSizeX = 75;
	public int MapSizeY = 75;

	public List<GameObject> wallObjectsList;

    int[,] map;

	// Use this for initialization
	void Start () {
        GenerateMap();
	}
	
    void GenerateMap(){
        map = new int[MapSizeX, MapSizeY];
        RandomFillMap();
        for (int i = 1; i < Smoothness; i++)
        {
            SmoothMap();
        } 

        DrawMap();
    }

    void RandomFillMap()
    {
        Random.InitState(Seed);

        for (int cntx = 0; cntx < MapSizeX; cntx++)
        {
            for (int cnty = 0; cnty < MapSizeY; cnty++)
            {
                if (Random.Range(0, 100) < Filledness || cntx == 0 || cntx == MapSizeX - 1 || cnty == 0 || cnty == MapSizeY - 1)
                {
                    map[cntx, cnty] = 1;
                }
                else
                {
                    map[cntx, cnty] = 0;
                }
            }
        }
    }

    void SmoothMap()
    {
        for (int cntx = 0; cntx < MapSizeX; cntx++)
        {
            for (int cnty = 0; cnty < MapSizeY; cnty++)
            {
                int neighbourWallTiles = GetSurroundingWallCount(cntx, cnty);

                if (neighbourWallTiles > 4)
                {
                    map[cntx, cnty] = 1;
                }
                else if (neighbourWallTiles < 4)
                {
                    map[cntx, cnty] = 0;
                }
            }
        }
    }

    int GetSurroundingWallCount(int gridX, int gridY)
    {
        int wallCount = 0;
        for (int neighbourX = gridX -1; neighbourX <= gridX + 1; neighbourX++)
        {
            for (int neighbourY = gridY - 1; neighbourY <= gridY + 1; neighbourY++)
            {
                if (neighbourX >= 0 && neighbourX < MapSizeX && neighbourY >= 0 && neighbourY < MapSizeY)
                {
                    if (neighbourX != gridX || neighbourY != gridY)
                    {
                        wallCount += map[neighbourX, neighbourY];
                    }
                }
                else
                {
                    wallCount += 1;
                }
            }
        }
        return wallCount;
    }

    void DrawMap(){
        if (map != null)
        {
            for (int cntx = 0; cntx < MapSizeX; cntx++)
            {
                for (int cnty = 0; cnty < MapSizeY; cnty++)
                {
                    if (map[cntx, cnty] == 1)
                    {
                        Instantiate(wallObjectsList[0], new Vector3(cntx, cnty, 0), Quaternion.identity);
                    }
                }
            }
        }
    }
}
