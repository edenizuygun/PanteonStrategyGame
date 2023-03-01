using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class ObjectInformation : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI itemName;
    [SerializeField] Image itemImage;
    [SerializeField] Image productionImage;
    public string objectName;



    [SerializeField] Sprite barracksImage;
    [SerializeField] Sprite barracksProductionImage;

    [SerializeField] Sprite powerplantImage;
    [SerializeField] Sprite soldier1Image;

    public static ObjectInformation instance;
    private void Awake()
    {
        instance = this;
    }


    public void UpgradeInformation() 
    {
        switch (objectName)
        {
            case ("BarracksGO(Clone)"):
                itemName.text = "Barracks";
                itemImage.sprite = barracksImage;
                productionImage.enabled = true;
                productionImage.sprite = barracksProductionImage;
            break;
            case ("PowerplantGO(Clone)"):
                itemName.text = "Powerplant";
                itemImage.sprite = powerplantImage;
                productionImage.enabled = false; 
                break;
            case ("Soldier1GO(Clone)"):
                itemName.text = "Soldier";
                itemImage.sprite = soldier1Image;
                productionImage.enabled = false;
                break;
            default:
                break;
        }


    }
}
