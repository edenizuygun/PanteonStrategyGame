using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrefabMovement : MonoBehaviour
{
    [SerializeField] GameObject occupationSprite;
    
    bool isOccupied;
    bool canDrag = true;

    [SerializeField] string clickManagerTag;
   ButtonClickManager clickManager;

    private void Start()
    {
        occupationSprite = transform.GetChild(0).gameObject;
        clickManager = GameObject.FindGameObjectWithTag(clickManagerTag).GetComponent<ButtonClickManager>();
    }


    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Clickable"))
        {
            isOccupied = true;
            occupationSprite.SetActive(true);
        }
    }
    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Clickable"))
        {
            isOccupied = false;
            occupationSprite.SetActive(false);
        }
    }

    private void Update()
    {
        
        if (canDrag)
        {
            PrefabPosition();
        }
       
           
        
        if (Input.GetMouseButtonDown(0) && !isOccupied)
        {
               AstarPath.active.Scan();
           
            canDrag = false;
            gameObject.layer = 6;
            clickManager.ActivateImage();
        }
       
    }
    void PrefabPosition()
    {
        transform.position = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y,10f));
    }

   
}
