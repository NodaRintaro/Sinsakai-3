using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMove : MonoBehaviour
{ 
    private Vector3 _dir;

    void Start()
    {
        _dir = new Vector3(0,0,-1);
    }

    void Update()
    {
        transform.position += _dir * Time.deltaTime * EnemyStates.Instance._movePower;
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
