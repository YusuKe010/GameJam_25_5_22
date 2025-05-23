using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LiftManagerVanish : MonoBehaviour
{
    /// <summary>���������ݒ�ł���B</summary>
    [SerializeField, Tooltip("���t�g�̈ړ�����")] liftmode liftmoving = default;
    int _liftmode;
    [SerializeField, Tooltip("�v���C���[����������ɍ쓮���邩(��{ON)")] bool playOnCollision = default;
    [SerializeField, Tooltip("���t�g�̈ړ����x")] float m_animSpeed = default;
    Animator m_anim = default;
    GameManager _gameManger;
    // Start is called before the first frame update
    void Start()
    {
        m_anim = GetComponent<Animator>();
        _liftmode = (int)liftmoving;
        Debug.Log(_liftmode);
        m_anim.SetInteger("Liftmoving", _liftmode);
        _gameManger = FindAnyObjectByType<GameManager>(); //GameManager��T���ăR���|�[�l���g�擾
    }

    // Update is called once per frame
    void Update()
    {
        m_anim.SetBool("PlayOnCollision", playOnCollision);
        m_anim.speed = m_animSpeed;
        if (_gameManger.PlayerColor == PlayerColor.Blue)
        {
            m_anim.enabled = true;
        }
        else
        {
            m_anim.enabled = false;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (playOnCollision == true)
        {
            if (collision.gameObject.tag == "Player")
            {
                playOnCollision = false;
            }
        }
    }

    private void Reseter()
    {
        playOnCollision = true;
        m_anim.SetBool("Reset?", true);
    }

    private void Starter()
    {
        m_anim.SetBool("Reset?", false);
    }

    enum liftmode
    {
        /// <summary>
        /// ���ɓ����ď�����B
        /// </summary>
        Left,
        /// <summary>
        /// ����ɓ����B
        /// </summary>
        LeftUp,
        /// <summary>
        /// ��ɓ����B
        /// </summary>
        Up,
        /// <summary>
        /// �E��ɓ����B
        /// </summary>
        RightUp,
        /// <summary>
        /// �E�ɓ����B
        /// </summary>
        Right,
        /// <summary>
        /// �����鋓���B
        /// </summary>
        Fall,
    }
}
