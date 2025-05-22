using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hari : MonoBehaviour
{
    [SerializeField] Transform respawnPoint;
    GameManager gameManager;
    public void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "Player" && gameManager.PlayerColor == PlayerColor.Red)
        {
            Debug.Log("�ԂȂ̂ŉ����N���܂���");
        }
        else if(other.gameObject.tag == "Player")
        {
            other.gameObject.transform.position = respawnPoint.position;   
            Debug.Log("�Ԃ���Ȃ��̂Ń��X�|�[�����܂���");
        }
    }
   

    // Start is called before the first frame update
    void Start()
    {
        gameManager = FindAnyObjectByType<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {

    }
}
   

