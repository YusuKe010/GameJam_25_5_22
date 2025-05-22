using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public int maxHP = 10;
    public int currentHP;
    [SerializeField] private Transform respawnPoint;
    // Start is called before the first frame update
    void Start()
    {
        currentHP = maxHP;
    }

    public void TakeDamege(int amount)
    {
        currentHP -= amount;

        if (currentHP <= 0)
        {
            currentHP = 0;
            Respawn();
        }
    }
    private void Respawn()
    {
        if (respawnPoint!= null)
        {
            transform.position = respawnPoint.position;
            currentHP = maxHP;


        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
