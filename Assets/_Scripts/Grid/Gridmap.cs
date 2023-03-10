using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gridmap : MonoBehaviour
{
    public int height;
    public int length;

    bool[,] grid;

    public void Init(int lenght,int height)
    {
        grid = new bool[lenght,height];
        this.length = lenght;
        this.height = height;
    }

    public void Set(int x, int y, bool to) 
    {
        if (CheckPosition(x, y) == false) { return; }
      
        grid[x, y] = to;
    }
    public bool Get(int x, int y)
    {
        if (CheckPosition(x, y) == false) { return false; }
        return grid[x,y];
    }

    public bool CheckPosition(int x,int y)
    {
        if (x <0 || x>=length)
        {
            return false;
        }
        if (y < 0 || y >= height)
        {
            return false;
        }

        return true;
    
    }
}
