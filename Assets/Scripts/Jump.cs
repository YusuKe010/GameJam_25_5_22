using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static Unity.VisualScripting.Member;

public class Jump : MonoBehaviour
{
    [SerializeField] private float jump = 15f;
    Rigidbody2D rb = default;
    bool isgrand=false;
    [SerializeField]
    private AudioSource source;
    [SerializeField] AudioClip clip;
    public bool IsGroud
    {
        // IsGroud���Ăяo�����Ƃ���isgrand�������Ă���
        get { return isgrand; }
    }
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();//Rigidbody2D��ǂݍ���
    }

    // Update is called once per frame
    void Update()
    {
        //Space����������jumpplayer�֐����Ăяo��
        if (Input.GetKeyDown(KeyCode.Space))
        {
            jumpplayer();
        }
    }

    public void jumpplayer()
    {
        //isground�ϐ���true�̏ꍇ�W�����v����悤�͂������A isgrand��false�ɂ���
        if (isgrand)
        {
            rb.AddForce(Vector2.up * jump, ForceMode2D.Impulse);
            source.PlayOneShot(clip); //���ʉ����Đ�
            isgrand = false;
        }
    }
    //�v���C���[�Ƃ��̂��������Ă��邩���肷��
    private void OnCollisionEnter2D(Collision2D collision)
    {
        //���������Q�[���I�u�W�F�N�g�̃^�O��Ground��Damage floor��������isgrand�ϐ���true�ɂ���
        if (collision.gameObject.tag == "Ground"|| collision.gameObject.tag == "Damage floor")
        {
            isgrand = true;
        } 
    }
}
