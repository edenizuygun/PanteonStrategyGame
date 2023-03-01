using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonClickManager : MonoBehaviour
{
    [SerializeField]GameObject itemImage;
    
    private void Start()
    {
        itemImage = transform.GetChild(0).gameObject;
    }

    public void OnButtonClick() 
    { 
        itemImage.SetActive(false);
        GetComponent<SpawnOnMousePosition>().SelectPrefab();
        
    }

    public void ActivateImage() { itemImage.SetActive(true); }

   
}
