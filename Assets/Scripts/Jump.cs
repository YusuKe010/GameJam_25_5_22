using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump : MonoBehaviour
{
    [SerializeField] private float jump = 15f;
    Rigidbody2D rb = default;
    bool isgrand=false;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            jumpplayer();
        }
    }

    public void jumpplayer()
    {
        if (isgrand)
        {
            rb.AddForce(Vector2.up * jump, ForceMode2D.Impulse);

            isgrand = false;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        isgrand = true;
    }
}
