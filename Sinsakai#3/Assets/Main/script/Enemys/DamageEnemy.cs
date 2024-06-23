using System.Collections;
using System.Collections.Generic;
using UnityEngine;

class DamageEnemy : EnemysType
{
    [SerializeField]private int _damage = 1;

    public override void EnemyEffect()
    {
        PlayerState.Instance.HPMinus(_damage);
    }
}
