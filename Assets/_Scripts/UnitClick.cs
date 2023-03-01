using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnitClick : MonoBehaviour
{
    public static UnitClick instance;
    public bool isSelected;
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            Vector2 mousePos2D = new Vector2(mousePos.x, mousePos.y);

            RaycastHit2D hit = Physics2D.Raycast(mousePos2D, Vector2.zero);
            if (hit.collider != null){ Debug.Log(hit.collider.gameObject.name); }
            
            if (hit.collider != null && hit.collider.gameObject.layer == 6 )
            {

                ObjectInformation.instance.objectName = hit.collider.gameObject.name;
                ObjectInformation.instance.UpgradeInformation();
               
                isSelected = true;

                Debug.Log("seleccteed");
                UnitSelection.instance.ClickSelect(hit.collider.gameObject);
               
            }
            else if (hit.collider != null && hit.collider.gameObject.layer == 3)
            {
                isSelected = false;
                Debug.Log("sssssss");
                UnitSelection.instance.DeselectAll();
            }
            
            
        }
    }

   

}
