using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    [SerializeField] float _movePower = 10;

    private Vector3 _dir = default;

    Rigidbody _rb;
    // Start is called before the first frame update
    void Start()
    {
        _rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        float x = Input.GetAxisRaw("Horizontal");
        //���E�̓���
        float z = Input.GetAxisRaw("Vertical");
        //�㉺�̓���
        _dir = new Vector3(x, 0, -z);

        _rb.velocity = _dir * _movePower;
    }
}
