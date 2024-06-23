using System.Collections;
using System.Collections.Generic;
using UnityEngine;

abstract class EnemysType : MonoBehaviour
{
    abstract public void EnemyEffect();

    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            EnemyEffect();
            EnemyManager.Instance.AddEnemy(this.gameObject);
        }
    }

    private void OnBecameInvisible()
    {
        EnemyManager.Instance.AddEnemy(this.gameObject);
    }
}
