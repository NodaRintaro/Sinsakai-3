using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMove : MonoBehaviour
{
    /// <summary>
    /// プレイヤーの移動速度
    /// </summary>
    [SerializeField] float _movePower = 10;
    
    private Vector3 _dir;   
    
    void Start()
    {
        
    }

    private void Update()
    {
        transform.position += _dir * Time.deltaTime * _movePower;
    }

    public void OnMove(InputValue value)
    {
        var Axis = value.Get<Vector2>();
        _dir = new Vector3(Axis.x, Axis.y, 0);
    }
}
