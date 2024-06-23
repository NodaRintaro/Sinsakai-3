using System.Collections;
using System.Collections.Generic;
using UnityEngine;

class ScorePlusEnemy : EnemysType
{
    [SerializeField] private int _healPower = 1;

    public override void EnemyEffect()
    {
        PlayerState.Instance.ScorePlus(_healPower);
    }
}
