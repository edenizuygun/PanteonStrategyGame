using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnOnMousePosition : MonoBehaviour
{
    GameObject objectPrefab;
    public ButtonType buttonType;
    [SerializeField]GameObject barracksPrefab;
    [SerializeField]GameObject plantPrefab;
    [SerializeField] GameObject soldier1Prefab;


 
    
    public void SelectPrefab() {
        
        switch (buttonType)
        {
            case ButtonType.Barracks:
                objectPrefab = barracksPrefab;
                break;
            case ButtonType.Powerplant:
                objectPrefab = plantPrefab;
                break;
            case ButtonType.Soldier1:
                objectPrefab = soldier1Prefab;
                break;
            default:
                Debug.Log("empty");
                break;
        }

        SpawnObject();
    }
  
     void SpawnObject() { 
        
        Instantiate(objectPrefab, MousePos(),Quaternion.identity) ;
        
       
    }
    Vector3 MousePos() {

      
        return Camera.main.ScreenToWorldPoint(Input.mousePosition);



    }
}
public enum ButtonType
{
    Barracks,
    Powerplant,
    Soldier1
}
