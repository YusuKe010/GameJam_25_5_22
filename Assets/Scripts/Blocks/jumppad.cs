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
    private AudioManager _audioManager;
    [SerializeField] AudioClip clip;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player" && gameManager.PlayerColor == PlayerColor.Yellow)
        {
            Rigidbody2D rb = collision.gameObject.GetComponent<Rigidbody2D>();

            if (rb != null)
            {
                Debug.Log("îΩâûÇÕÇµÇƒÇÈÇº");
                Vector3 currentVelocity = rb.velocity;
                currentVelocity.y = 0;
                rb.velocity = currentVelocity;
                rb.AddForce(Vector3.up * jumpForce, ForceMode2D.Impulse);
                _audioManager.PlaySE(clip); //å¯â âπÇçƒê∂
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
