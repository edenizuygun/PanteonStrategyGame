using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyBuildings : MonoBehaviour,IDamageable
{
    public PooledObject pooledObject;
    public ScriptableObjects goSO;
    public ItemName itemName;

    void Start()
    {
        switch (itemName)
        {
            case ItemName.Barracks:
                goSO.maxHealth=10;
                break;
            case ItemName.Powerplant:
                goSO.maxHealth = 5;
                break;
            default:
                break;
        }

        goSO.health = goSO.maxHealth;
    }

    public void GetDamage(int amount)
    {
        if (goSO.health > 0)
        {
            goSO.health -= amount;

        }
        else
        {
            gameObject.SetActive(false);
        }

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Bullet"))
        {
            Debug.Log("bulluet gleid");
            switch (itemName)
            {
                case ItemName.Barracks:
                    GetDamage(2);
                    Debug.Log("dmg taken b");
                    break;
                case ItemName.Powerplant:
                    Debug.Log("dmg taken p");
                    GetDamage(1);
                    break;
                default:
                    break;
            }


        }
    }

}
public enum ItemName
{
    Barracks,
    Powerplant,
}
