using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    [SerializeField] private PlayerInput _playerInput;
    [SerializeField] private PlayerController _controller;
    [SerializeField] private float _speed = 1f;
    [SerializeField] private float _fall = 1f;
    Rigidbody2D _rb = default;
    // Start is called before the first frame update
    void Start()
    {
        //Jump���N���X��ǂݍ���
        _rb = GetComponent<Rigidbody2D>();
        _playerInput.Input += MoveForse;
        _playerInput.OnInputS += Fall;
    }


    private void MoveForse(Vector2 input)
    {
        //D�������Ă���ԁA�E�ɐi��
        //A�������Ă���ԁA���ɐi��
        _rb.velocity = new Vector2(input.x * _speed, _rb.velocity.y);
    }

    private void Fall()
    {
        //S�������Ă����+�󒆂ɂ���ԁA������Ƃ��ɑ��x������������
        //&&�̌��Jump.IsGroud�͂��̃N���X��IsGroud������
        if (_controller.IsGround == false)
        {
            // transform.position -= new Vector3(0, fall * Time.deltaTime, 0);
            _rb.AddForce(Vector2.down * _fall * 0.2f);
        }
    }
}
