using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class push : MonoBehaviour
{
    Rigidbody2D rb;
    GameManger gameManager;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        gameManager = FindAnyObjectByType<GameManger>();

    }

    // Update is called once per frame
    void Update()
    {
        if (gameManager.PlayerColor == PlayerColor.Green)
        {
            rb.WakeUp();
            rb.isKinematic = false;
        }
        else
        {
            rb.Sleep();
            rb.isKinematic = true;
        }
    }
}
