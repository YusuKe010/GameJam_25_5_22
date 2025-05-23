using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamegeFloordoku : MonoBehaviour
{
    GameManager gameManeger;
    public int damegeAmount = 10;
    public float damageInterval = 1f;

    private float damageTimer = 0f;
    private void OnCollisionStay2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player")&&gameManeger.PlayerColor!=PlayerColor.Purple)
        {
            damageTimer += Time.deltaTime;
            if (damageTimer >= damageInterval)
            {
                PlayerHealth player = collision.gameObject.GetComponent<PlayerHealth>();
                if (player != null)
                {
                    player.TakeDamege(damegeAmount);
                    damageTimer = 0f;
                    Debug.Log("Damage");
                }
            }
                    Debug.Log("Damage" + damageTimer);
           

        }
    }
    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player") )
        {
            damageTimer = 0f;
        }
           

        
    }
    void Start()
    {
        
        gameManeger = FindAnyObjectByType<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
