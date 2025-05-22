using DG.Tweening.Core.Easing;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpPad : MonoBehaviour
{
    public float jumpForce = 10f;
    GameManger gameManager;

    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "Player" && gameManager.PlayerColor == PlayerColor.Yellow)
        {
            Rigidbody2D rb = other.gameObject.GetComponent<Rigidbody2D>();

            if (rb != null)
            {
                Debug.Log("”½‰ž‚Í‚µ‚Ä‚é‚¼");
                Vector3 currentVelocity = rb.velocity;
                currentVelocity.y = 0;
                rb.velocity = currentVelocity;
                rb.AddForce(Vector3.up * jumpForce, ForceMode2D.Impulse);
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
