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
        //Jump���N���X��ǂݍ���
        Jump = GetComponent<Jump>();
        rb = GetComponent<Rigidbody2D>();
    }
    // Update is called once per frame
    void Update()
    {
        //D�������Ă���ԁA�E�ɐi��
        if (Input.GetKey(KeyCode.D))
        {
            //transform.position += speed * Vector3.right * Time.deltaTime;
            rb.AddForce(Vector2.right * speed*10);
        }
        //A�������Ă���ԁA���ɐi��
        if (Input.GetKey(KeyCode.A))
        {
            rb.AddForce(Vector2.left * speed*10);
            //transform.position -= speed * Vector3.right * Time.deltaTime;
        }
        //S�������Ă����+�󒆂ɂ���ԁA������Ƃ��ɑ��x������������
        //&&�̌��Jump.IsGroud�͂��̃N���X��IsGroud������
        if (Input.GetKey(KeyCode.S) && Jump.IsGroud == false)
        {
           // transform.position -= new Vector3(0, fall * Time.deltaTime, 0);
            rb.AddForce(Vector2.down * fall*20);
        }
        //W����������Jump�N���X��jumpplayer�֐����Ăяo��
        if (Input.GetKeyDown(KeyCode.W))
        {
            Jump.jumpplayer();
        }
    }
}
