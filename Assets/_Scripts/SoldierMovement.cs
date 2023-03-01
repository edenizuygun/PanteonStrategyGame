using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Pathfinding;

public class SoldierMovement : MonoBehaviour
{
    private AIPath aiPath;
    public bool canMove;

    void Awake()
    {
            aiPath = GetComponent<AIPath>();
    }

    
    void Update()
    {

        if (Input.GetMouseButtonDown(1))
        {
           

            if (UnitSelection.instance.units.Contains(gameObject))
            {
                canMove = true;
            }
 
            
        }
        if (canMove)
        {
            foreach (GameObject item in UnitSelection.instance.units)
            {
                aiPath.destination = GridControl.instance.clickPosition;
                
            }
          

        }

        if (Vector3.Distance(GridControl.instance.clickPosition, transform.position) < 1f)
        {
            canMove = false;
        }

       
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (Vector3.Distance(GridControl.instance.clickPosition, transform.position) < 2f)
        {
            aiPath.destination = GridControl.instance.clickPosition + new Vector3(Random.Range(2, UnitSelection.instance.units.Count+1),0,0);
        }
    }
}
