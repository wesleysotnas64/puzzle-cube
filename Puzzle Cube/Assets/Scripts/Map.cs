using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Map : MonoBehaviour
{
    public int[,] tiles;
    public int size;
    public Vector2 initPlayerPosition;

    public GameObject lake;
    public GameObject tile_01;

    void Start()
    {
        Map_003();
        // Map_Test();
        InitMap();
    }

    private void InitMap()
    {
        GameObject lakeInstant = Instantiate(lake);
        lakeInstant.transform.localScale = new Vector3(size+4, 1,size+4);
        lakeInstant.transform.position = new Vector3(0, lakeInstant.transform.position.y, 0);

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

        GameObject.Find("Player").transform.position = new Vector3(initPlayerPosition.x, 1, initPlayerPosition.y);
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

    private void Map_Test()
    {
        size = 3;
        tiles = new int[size, size];
        AddZero();
        initPlayerPosition = new Vector2(-1, 1);


        //Tiles Map
        tiles[0, 0] = 1;
        tiles[2, 2] = 1;
        
    }

    private void Map_001()
    {
        size = 5;
        tiles = new int[size, size];
        AddZero();
        initPlayerPosition = new Vector2(-2, 0);


        //Tiles Map
        tiles[2, 0] = 1;
        tiles[2, 1] = 1;
        tiles[2, 2] = 1;
        tiles[2, 3] = 1;
        tiles[2, 4] = 1;
    }

    private void Map_002()
    {
        size = 5;
        tiles = new int[size, size];
        AddZero();
        initPlayerPosition = new Vector2(-2, -2);


        //Tiles Map
        tiles[4, 0] = 1;
        tiles[4, 1] = 1;
        tiles[3, 1] = 1;
        tiles[3, 2] = 1;
        tiles[2, 2] = 1;
        tiles[1, 2] = 1;
        tiles[0, 2] = 1;
        tiles[0, 3] = 1;
        tiles[0, 4] = 1;
    }

    private void Map_003()
    {
        size = 5;
        tiles = new int[size, size];
        AddZero();
        initPlayerPosition = new Vector2(-2, 2);


        //Tiles Map
        tiles[0, 0] = 1;
        tiles[0, 1] = 1;
        tiles[0, 2] = 1;
        tiles[0, 3] = 1;
        tiles[0, 4] = 1;
        tiles[1, 4] = 1;
        tiles[2, 4] = 1;
        tiles[3, 4] = 1;
        tiles[4, 4] = 1;
        tiles[4, 3] = 1;
        tiles[4, 2] = 1;
        tiles[4, 1] = 1;
        tiles[4, 0] = 1;
        tiles[3, 0] = 1;
        tiles[2, 0] = 1;
        tiles[2, 1] = 1;
        tiles[2, 2] = 1;
        
    }
}
