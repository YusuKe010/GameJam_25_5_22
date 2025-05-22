using DG.Tweening.Core.Easing;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static Unity.VisualScripting.Member;

public class JumpPad : MonoBehaviour
{
    public float jumpForce = 10f;
    GameManger gameManager;
    [SerializeField]
    private AudioSource source;
    [SerializeField] AudioClip clip;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player") && gameManager.PlayerColor == PlayerColor.Yellow)
        {
            Rigidbody2D rb = other.GetComponent<Rigidbody2D>();

            if (rb != null)
            {
                Vector3 currentVelocity = rb.velocity;
                currentVelocity.y = 0;
                rb.velocity = currentVelocity;
                rb.AddForce(Vector3.up * jumpForce, ForceMode2D.Impulse);
                source.PlayOneShot(clip); //å¯â âπÇçƒê∂
            }
        }
    }

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
}
