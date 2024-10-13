using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Map : MonoBehaviour
{
    public int mapId;
    public int[,] tiles;
    public int lineX; 
    public int columZ;
    public Vector2 initPlayerPosition;

    
    public GameObject lake;
    public GameObject tile_01; // 1
    public GameObject lotusFlowerSmall; // 101
    public GameObject lotusFlowerBig; // 102

    void Start()
    {
        switch (mapId)
        {
            case 1:
                Map_001();
                break;

            default:
                Map_Test();
                break;
        }
        
        // Map_Test();
        InitMap();
    }

    private void InitMap()
    {
        // GameObject lakeInstant = Instantiate(lake);
        // lakeInstant.transform.localScale = new Vector3(size+4, 1,size+4);
        // lakeInstant.transform.position = new Vector3(0, lakeInstant.transform.position.y, 0);

        // int tileZposition = size/2;
        for(int i = 0; i < lineX; i++)
        {
            // int tileXposition = -size/2;
            for(int j = 0; j < columZ; j++)
            {
                switch(tiles[i, j])
                {
                    case 1: 
                        Instantiate(tile_01).transform.position = transform.position + new Vector3(i, 0, j);
                        break;

                    case 101:
                        Instantiate(lotusFlowerSmall).transform.position = transform.position + new Vector3(i, 0, j);
                        break;

                    case 102:
                        Instantiate(lotusFlowerBig).transform.position = transform.position + new Vector3(i, 0, j);
                        break;

                    default:
                        break;
                }
                // tileXposition++;
            }
            // tileZposition--;
        }

        GameObject.Find("Player").transform.position = new Vector3(initPlayerPosition.x, 1, initPlayerPosition.y);
    }

    private void AddZero()
    {
        for(int i = 0; i < lineX; i++)
        {
            for(int j = 0; j < columZ; j++)
            {
                tiles[i, j] = 0;
            }
        }
    }

    private void Map_Test()
    {
        lineX = 13;
        columZ = 7;
        tiles = new int[lineX, columZ];
        AddZero();
        initPlayerPosition = new Vector2(0, 1);


        //Tiles Map
        tiles[0, 1] = 1;
        tiles[1, 1] = 1;
        tiles[1, 2] = 1;
        tiles[2, 2] = 1;
        tiles[2, 3] = 1;
        tiles[2, 4] = 1;
        tiles[2, 5] = 1;
        tiles[3, 5] = 1;
        tiles[4, 5] = 1;
        tiles[4, 4] = 1;
        tiles[4, 3] = 1;
        tiles[5, 3] = 1;
        tiles[5, 4] = 1;
        tiles[5, 5] = 1;
        tiles[6, 5] = 1;
        tiles[6, 4] = 1;
        tiles[6, 3] = 1;
        tiles[6, 2] = 1;
        tiles[5, 2] = 1;
        tiles[5, 1] = 1;
        tiles[5, 0] = 1;
        tiles[6, 0] = 1;
        tiles[7, 0] = 1;
        tiles[8, 0] = 1;
        tiles[9, 0] = 1;
        tiles[9, 1] = 1;
        tiles[8, 1] = 1;
        tiles[8, 2] = 1;
        tiles[9, 2] = 1;
        tiles[10, 2] = 1;
        tiles[11, 2] = 1;
        tiles[11, 3] = 1;
        tiles[10, 3] = 1;
        tiles[9, 3] = 1;
        tiles[8, 3] = 1;
        tiles[8, 4] = 1;
        tiles[9, 4] = 1;
        tiles[10, 4] = 1;
        tiles[11, 4] = 1;
        tiles[12, 4] = 1;
        

        //Objetos
        tiles[0, 0] = 101;
        tiles[3, 1] = 102;
        tiles[3, 4] = 101;
        tiles[6, 1] = 101;
        tiles[12, 0] = 102;
        tiles[12, 3] = 101;
        tiles[12, 5] = 101;

    }

    private void Map_001()
    {
        // size = 5;
        // tiles = new int[size, size];
        // AddZero();
        // initPlayerPosition = new Vector2(-2, 0);


        // //Tiles Map
        // tiles[2, 0] = 1;
        // tiles[2, 1] = 1;
        // tiles[2, 2] = 1;
        // tiles[2, 3] = 1;
        // tiles[2, 4] = 1;

        // //Objetos
        // tiles[0, 0] = 101;
        // tiles[1, 4] = 101;
        // tiles[3, 4] = 101;
    }

}
