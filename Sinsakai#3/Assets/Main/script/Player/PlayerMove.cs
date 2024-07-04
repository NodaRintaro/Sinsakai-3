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

    private Vector3 _dir = default;

    private void Update()
    {
        float time = Time.deltaTime;
        transform.position += _dir * Time.deltaTime * _movePower;
        PlayerState.Instance.ScorePlus(time);
    }

    public void OnMove(InputValue value)
    {
        var Axis = value.Get<Vector2>();
        _dir = new Vector3(Axis.x, 0, Axis.y);
    }
}
