using System.Collections;
using System.Collections.Generic;
using UnityEngine;

class DamageEnemy : EnemysType
{
    [SerializeField] int _damage = 1;

    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            EnemyEffect();
            Destroy(this.gameObject);
        }
    }

    public override void EnemyEffect()
    {
        PlayerState.Instance.HPMinus(_damage);
    }
}
