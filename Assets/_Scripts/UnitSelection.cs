using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnitSelection : MonoBehaviour
{
    public static UnitSelection instance;

    public List<GameObject> units;
    
    private void Awake()
    {
        instance = this;
    }
    private void Start()
    {
        DeselectAll();
    }
    public void ClickSelect(GameObject unitToAdd) 
    {
        if (!units.Contains(unitToAdd))
        {
            units.Add(unitToAdd);
            unitToAdd.transform.GetChild(1).gameObject.SetActive(true);
        }
        
    }

    public void DeselectAll() 
    {
        foreach (var item in units)
        {
            item.transform.GetChild(1).gameObject.SetActive(false);
        }
        units.Clear(); 
    }
}
