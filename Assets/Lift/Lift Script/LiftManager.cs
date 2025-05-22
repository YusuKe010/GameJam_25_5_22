using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LiftManager : MonoBehaviour
{
    /// <summary>���������ݒ�ł���B</summary>
    [SerializeField, Tooltip("���t�g�̈ړ�����(�΂߈ړ����t�g�̎��͉E�̂ق����Q��)")] Liftmode liftmoving = default;
    int _liftmode;
    [SerializeField, Tooltip("�v���C���[����������ɍ쓮���邩")] bool playOnCollision = default;
    [SerializeField, Tooltip("���t�g�̈ړ����x")] float m_animSpeed = default;
    AudioSource m_audioSource;
    Animator m_anim = default;
    GameManger _gameManger;
    // Start is called before the first frame update
    void Start()
    {
        m_anim = GetComponent<Animator>();
        m_audioSource = GetComponent<AudioSource>();
        _liftmode = (int)liftmoving;
        m_anim.SetInteger("Liftmoving", _liftmode);
        _gameManger = FindAnyObjectByType<GameManger>();//GameManager��T���ăR���|�[�l���g�擾
        
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

    public void SwitchOn()
    {
        playOnCollision = false;
    }

    public void LiftSound()
    {
        m_audioSource.Play();
    }

    enum Liftmode
    {
        /// <summary>
        /// ��/�E���ɓ����B
        /// </summary>
        Up_RightDown,
        /// <summary>
        /// ��/�����ɓ����B
        /// </summary>
        Down_LeftDown,
        /// <summary>
        /// ��/����ɓ����B
        /// </summary>
        Left_LeftUp,
        /// <summary>
        /// �E/�E��ɓ����B
        /// </summary>
        Right_RightUp,
    }
}
