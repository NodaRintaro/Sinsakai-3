using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMove : MonoBehaviour
{
    [SerializeField] float _movePower = 10;
    
    private Vector3 _dir;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void OnMove(InputValue value)
    {
        var Axis = value.Get<Vector2>();
        _dir = new Vector3(Axis.x, Axis.y, 0);
    }

    private void Update()
    {
        transform.position += _dir * Time.deltaTime * _movePower;
    }
}
