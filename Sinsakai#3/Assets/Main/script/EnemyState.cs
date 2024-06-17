using System.Collections;
using System.Collections.Generic;
using UnityEngine;

abstract class EnemyState: MonoBehaviour
{
    public void EnemyModel()
    {
        _enemyModel();
    }

    protected abstract GameObject _enemyModel();

    enum EnemyType
    {
        damage,
        heal,
        speed,
    }
}
