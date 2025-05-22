using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    [SerializeField] float speed = 1f;
    [SerializeField] float fall = 1f;
    Jump Jump = default;
    Rigidbody2D rb = default;
    // Start is called before the first frame update
    void Start()
    {
        //Jumpをクラスを読み込む
        Jump = GetComponent<Jump>();
        rb = GetComponent<Rigidbody2D>();
    }
    // Update is called once per frame
    void Update()
    {
        //Dを押している間、右に進む
        if (Input.GetKey(KeyCode.D))
        {
            //transform.position += speed * Vector3.right * Time.deltaTime;
            rb.AddForce(Vector2.right * speed*10);
        }
        //Aを押している間、左に進む
        if (Input.GetKey(KeyCode.A))
        {
            rb.AddForce(Vector2.left * speed*10);
            //transform.position -= speed * Vector3.right * Time.deltaTime;
        }
        //Sを押している間+空中にいる間、落ちるときに速度を加速させる
        //&&の後のJump.IsGroudはそのクラスのIsGroudを見る
        if (Input.GetKey(KeyCode.S) && Jump.IsGroud == false)
        {
           // transform.position -= new Vector3(0, fall * Time.deltaTime, 0);
            rb.AddForce(Vector2.down * fall*20);
        }
        //Wを押したらJumpクラスのjumpplayer関数を呼び出す
        if (Input.GetKeyDown(KeyCode.W))
        {
            Jump.jumpplayer();
        }
    }
}
