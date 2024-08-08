using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class EnemyStates : MonoBehaviour
{
    private static EnemyStates instance = new EnemyStates();
    public static EnemyStates Instance => instance;

    [SerializeField] public float _movePower = 10f;

    [SerializeField] private float _speed = 0.2f;

    private void Start()
    {
        
    }

    public void EnemyEffect()
    {
        PlayerStatus.Instance.CurrentHP(1);
    }

    private void OnBecameInvisible()
    {
        
    }

    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            

        }
    }
}
