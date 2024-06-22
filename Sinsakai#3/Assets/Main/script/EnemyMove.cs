using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMove : MonoBehaviour
{
    /// <summary>
    /// “G‚ÌˆÚ“®‘¬“x
    /// </summary>
    [SerializeField] float _movePower = 10;

    private Vector3 _dir;

    // Start is called before the first frame update
    void Start()
    {
        _dir = new Vector3(0,0,-1);
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += _dir * Time.deltaTime * _movePower;
    }
}
