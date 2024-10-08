using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Map : MonoBehaviour
{
    public int[,] tiles;
    public int size;
    public Vector2 initPlayerPosition;

    public GameObject tile_01;

    void Start()
    {
        Map_001();
        InitMap();
    }

    private void InitMap()
    {
        
        int tileZposition = size/2;
        for(int i = 0; i < size; i++)
        {
            int tileXposition = -size/2;
            for(int j = 0; j < size; j++)
            {
                if(tiles[i, j] == 1) Instantiate(tile_01).transform.position += new Vector3(tileXposition, 0, tileZposition);
                tileXposition++;
            }
            tileZposition--;
        }
    }

    private void AddZero()
    {
        for(int i = 0; i < size; i++)
        {
            for(int j = 0; j < size; j++)
            {
                tiles[i, j] = 0;
            }
        }
    }

    private void Map_001()
    {
        size = 8;
        tiles = new int[size, size];
        AddZero();

        //Tiles Map
        tiles[3, 0] = 1;
        tiles[3, 1] = 1;
        tiles[3, 2] = 1;
        tiles[3, 3] = 1;
        tiles[3, 4] = 1;
        tiles[3, 5] = 1;
        tiles[3, 6] = 1;
        tiles[3, 7] = 1;
    }
}
