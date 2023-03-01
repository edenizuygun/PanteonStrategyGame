using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

[RequireComponent(typeof(Gridmap))]
[RequireComponent(typeof(Tilemap))]
public class GridManager : MonoBehaviour
{
    Tilemap tilemap;
    Gridmap grid;
    [SerializeField] TileBase tileBase;
    [SerializeField] TileBase tileBase2;
    // Start is called before the first frame update
    void Start()
    {
        tilemap = GetComponent<Tilemap>();
        grid = GetComponent<Gridmap>();
        grid.Init(25,10);
       // grid.Set(0,0,true);
        UpdateTilemap();
    }
    void UpdateTilemap() 
    {
        for (int x = 0; x < grid.length; x++)
        {
            for (int y = 0; y < grid.height; y++)
            {
                if (grid.Get(x,y)==true)
                {
                     tilemap.SetTile(new Vector3Int(x,y,0), tileBase);

                }
                else
                {
                    tilemap.SetTile(new Vector3Int(x, y, 0), tileBase2);
                }
            }
        }
    }
 
   
}
