using DG.Tweening.Core.Easing;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static Unity.VisualScripting.Member;

public class JumpPad : MonoBehaviour
{
    public float jumpForce = 10000f;
    GameManger gameManager;
    [SerializeField]
    private AudioSource source;
    [SerializeField] AudioClip clip;

    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "Player" && gameManager.PlayerColor == PlayerColor.Yellow)
        {
            Rigidbody2D rb = other.gameObject.GetComponent<Rigidbody2D>();

            if (rb != null)
            {
                Debug.Log("�����͂��Ă邼");
                Vector3 currentVelocity = rb.velocity;
                currentVelocity.y = 0;
                rb.velocity = currentVelocity;
                rb.AddForce(Vector3.up * jumpForce, ForceMode2D.Impulse);
                source.PlayOneShot(clip); //���ʉ����Đ�
            }
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        gameManager = FindAnyObjectByType<GameManger>();
    }

    // Update is called once per frame
    void Update()
    {

    }
}
