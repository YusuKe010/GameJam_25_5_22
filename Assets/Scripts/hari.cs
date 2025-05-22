using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hari : MonoBehaviour
{
    [SerializeField] Transform respawnPoint;
    GameManger gameManager;
    public void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "Player" && gameManager.PlayerColor == PlayerColor.Red)
        {
            Debug.Log("赤なので何も起きません");
        }
        else if(other.gameObject.tag == "Player")
        {
            other.gameObject.transform.position = respawnPoint.position;   
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
   

