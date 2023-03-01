using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public PooledObject pooledObject;
    private GameObject target;

   
    void Update()
    {
        if (target!=null)
        {
            BulletMove();
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "BarracksGO(Clone)" || collision.gameObject.name == "PowerplantGO(Clone)" )
        {
            pooledObject.ReturnToPool();
         
        }
    }
    public void BulletMove() {
        transform.position = Vector3.MoveTowards(transform.position, target.transform.position, 1f * Time.deltaTime);

    }

    public void SetTarget(GameObject _target) 
    {
        target = _target;
    }
}
