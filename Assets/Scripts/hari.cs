using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hari : MonoBehaviour
{
    [SerializeField] Transform respawnPoint;
    GameManger gameManager;
    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player") && gameManager.PlayerColor == PlayerColor.Red)
        {
            Debug.Log("赤なので何も起きません");
        }
        else if(other.CompareTag("Player"))
        {
            transform.position = respawnPoint.position;   
            Debug.Log("赤じゃないのでリスポーンしました");
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
   

