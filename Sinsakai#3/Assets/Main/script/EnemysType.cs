using System.Collections;
using System.Collections.Generic;
using UnityEngine;

abstract class EnemysType : MonoBehaviour
{
    abstract public void EnemyEffect();

    private enum EnemyType
    {
     heal,
     damage,
     speed,
    }
}
