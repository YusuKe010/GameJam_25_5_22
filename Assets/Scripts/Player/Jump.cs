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
        _rb = GetComponent<Rigidbody2D>();//Rigidbody2Dを読み込む
        _playerInput.OnInputJump += jumpplayer;//Spaceを押したらjumpplayer関数を呼び出す
    }

    private void FixedUpdate()
    {
        DownForce();
    }


    private void jumpplayer()
    {
        //isground変数がtrueの場合ジャンプするよう力を加え、 isgrandをfalseにする
        if (_playerController.IsGround)
        {
            //_rb.velocity = new Vector2(_rb.velocity.x, 0f); // 上方向の速度をリセット
            _rb.AddForce(Vector2.up * _jumpForce, ForceMode2D.Impulse);
            _audioManager.PlaySE(_jumpSE); //効果音を再生
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
