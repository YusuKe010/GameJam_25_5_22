using UnityEngine;

public class Jump : MonoBehaviour
{
    [SerializeField] private float _jumpForce = 15f;
    [SerializeField] private float _gravityForce = 15f;
    [SerializeField] private AudioClip _jumpSE;
    [SerializeField] private AudioManager _audioManager;
    [SerializeField] private PlayerInput _playerInput;
    [SerializeField] private PlayerController _playerController;
    private Rigidbody2D _rb = default;

    void Start()
    {
        _rb = GetComponent<Rigidbody2D>();//Rigidbody2D��ǂݍ���
        _playerInput.OnInputJump += jumpplayer;//Space����������jumpplayer�֐����Ăяo��
    }

    private void FixedUpdate()
    {
        DownForce();
    }


    private void jumpplayer()
    {
        //isground�ϐ���true�̏ꍇ�W�����v����悤�͂������A isgrand��false�ɂ���
        if (_playerController.IsGround)
        {
            //_rb.velocity = new Vector2(_rb.velocity.x, 0f); // ������̑��x�����Z�b�g
            _rb.AddForce(Vector2.up * _jumpForce, ForceMode2D.Impulse);
            _audioManager.PlaySE(_jumpSE); //���ʉ����Đ�
            _playerController.IsGround = false;
            Debug.Log("Jump");
        }
    }


    private void DownForce()
    {
        if (!_playerController.IsGround)
        {
            _rb.AddForce(Vector2.down * _gravityForce * 0.2f, ForceMode2D.Force);
        }
    }
}
