using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoldierAttack : MonoBehaviour
{
    public GameObject target;
    public static SoldierAttack instance;

    Bullet bullet;

    bool attackCd;
    private void Awake()
    {
        instance = this;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name== "BarracksGO(Clone)" || collision.gameObject.name == "PowerplantGO(Clone)" && !attackCd)
        {
            target = collision.gameObject;
            
            Attack();
        }
    }
    void Attack() 
    {
       var item= ObjectPool.Instance.GetPooledObject(PooledObjectType.Bullet,true);   
        bullet = item.gameObject.GetComponent<Bullet>();
        bullet.pooledObject = item;
        bullet.gameObject.transform.position=transform.position;
        bullet.SetTarget(target);
        StartCoroutine(Cooldown()) ;


    }

    IEnumerator Cooldown() {

        attackCd = true;
        yield return new WaitForSeconds(0.5f);
        attackCd = false;
    }
}

