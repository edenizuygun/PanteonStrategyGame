using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class GridControl : MonoBehaviour
{
    [SerializeField] Tilemap targetTilemap;

    public Vector3 worldPoint;
    public Vector3 clickPosition;

    public static GridControl instance;
    private void Awake()
    {
        instance = this;
    }
    private void Update()
    {
        
        if (Input.GetMouseButtonDown(1))
        {
             worldPoint = Camera.main.ScreenToWorldPoint(Input.mousePosition);
             clickPosition = targetTilemap.WorldToCell(worldPoint);
          
        }
    }
}
