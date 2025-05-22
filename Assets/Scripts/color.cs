using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class color : MonoBehaviour
{
    GameManger gameManager;
    // Start is called before the first frame update
    void Start()
    {
        gameManager = FindAnyObjectByType<GameManger>();
        Material mat = this.GetComponent<Renderer>().material; // ���ݎg�p����Ă���}�e���A�����擾 
        GetComponent<Renderer>().material.color = Color.red;//�܂��ԂɕύX
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(1))//�E�N���b�N�ŐF��ύX
        {
            switch (gameManager.PlayerColor)
            {
                case PlayerColor.Red:
                    gameManager.ChangePlayerColor(PlayerColor.Blue);
                    GetComponent<Renderer>().material.color = Color.blue;
                    Debug.Log(gameManager.PlayerColor);
                    break;
                case PlayerColor.Blue:
                    gameManager.ChangePlayerColor(PlayerColor.Yellow);
                    GetComponent<Renderer>().material.color = Color.yellow;
                    Debug.Log(gameManager.PlayerColor);
                    break;
                case PlayerColor.Yellow:
                    gameManager.ChangePlayerColor(PlayerColor.Green);
                    GetComponent<Renderer>().material.color = Color.green;
                    Debug.Log(gameManager.PlayerColor);
                    break;
                case PlayerColor.Green:
                    gameManager.ChangePlayerColor(PlayerColor.Red);
                    GetComponent<Renderer>().material.color = Color.red;
                    Debug.Log(gameManager.PlayerColor);
                    break;
            }
        }
    }
}

