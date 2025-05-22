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
        //Jumpをクラスを読み込む
        _rb = GetComponent<Rigidbody2D>();
        _playerInput.Input += MoveForse;
        _playerInput.OnInputS += Fall;
    }


    private void MoveForse(Vector2 input)
    {
        //Dを押している間、右に進む
        //Aを押している間、左に進む
        _rb.velocity = new Vector2(input.x * _speed, _rb.velocity.y);
    }

    private void Fall()
    {
        //Sを押している間+空中にいる間、落ちるときに速度を加速させる
        //&&の後のJump.IsGroudはそのクラスのIsGroudを見る
        if (_controller.IsGround == false)
        {
            // transform.position -= new Vector3(0, fall * Time.deltaTime, 0);
            _rb.AddForce(Vector2.down * _fall * 0.2f);
        }
    }
}
