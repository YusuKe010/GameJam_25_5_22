using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamegeFloor : MonoBehaviour
{
    public int damageAmount = 100;
    public void OnTriggerEnter2D(Collider2D other)
   {
        if (other.CompareTag("Player"))
        {
            PlayerHealth playerHealth = other.GetComponent<PlayerHealth>();
            if (playerHealth != null)
            {
                playerHealth.TakeDamege(damageAmount);
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
