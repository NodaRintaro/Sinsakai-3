using System.Collections;
using System.Collections.Generic;
using UnityEngine;

class SpeedEnemy : EnemysType
{
    [SerializeField]private float _speed = 0.2f;
    public override void EnemyEffect()
    {
        EnemyManager.Instance._movePower += _speed;
    }
}
