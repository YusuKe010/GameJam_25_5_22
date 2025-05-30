using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class color : MonoBehaviour
{
    [SerializeField] PlayerColor startColor;
    GameManager gameManager;
    // Start is called before the first frame update
    void Start()
    {
        gameManager = FindAnyObjectByType<GameManager>();
        Material mat = this.GetComponent<Renderer>().material; // 現在使用されているマテリアルを取得 
        gameManager.ChangePlayerColor(startColor);
        switch (startColor)
        {
            case PlayerColor.Red:
                GetComponent<SpriteRenderer>().color = Color.red;
                Debug.Log(gameManager.PlayerColor);
                break;
            case PlayerColor.Blue:
                GetComponent<SpriteRenderer>().color = Color.blue;
                Debug.Log(gameManager.PlayerColor);
                break;
            case PlayerColor.Yellow:
                GetComponent<SpriteRenderer>().color = Color.yellow;
                Debug.Log(gameManager.PlayerColor);
                break;
            case PlayerColor.Green:
                GetComponent<SpriteRenderer>().color = Color.green;
                Debug.Log(gameManager.PlayerColor);
                break;
            case PlayerColor.Purple:
                GetComponent<SpriteRenderer>().color = new Color(0.6f, 0, 1);
                Debug.Log(gameManager.PlayerColor);
                break;
        }
        GetComponent<SpriteRenderer>().color = Color.red;//まず赤に変更
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(1))//右クリックで色を変更
        {
            switch (gameManager.PlayerColor)
            {
                case PlayerColor.Red:
                    gameManager.ChangePlayerColor(PlayerColor.Blue);
                    GetComponent<SpriteRenderer>().color = Color.blue;
                    Debug.Log(gameManager.PlayerColor);
                    break;
                case PlayerColor.Blue:
                    gameManager.ChangePlayerColor(PlayerColor.Yellow);
                    GetComponent<SpriteRenderer>().color = Color.yellow;
                    Debug.Log(gameManager.PlayerColor);
                    break;
                case PlayerColor.Yellow:
                    gameManager.ChangePlayerColor(PlayerColor.Green);
                    GetComponent<SpriteRenderer>().color = Color.green;
                    Debug.Log(gameManager.PlayerColor);
                    break;
                case PlayerColor.Green:
                    gameManager.ChangePlayerColor(PlayerColor.Purple);
                    GetComponent<SpriteRenderer>().color = new Color(0.6f, 0, 1);
                    Debug.Log(gameManager.PlayerColor);
                    break;
                case PlayerColor.Purple:
                    gameManager.ChangePlayerColor(PlayerColor.Red);
                    GetComponent<SpriteRenderer>().color = Color.red;
                    Debug.Log(gameManager.PlayerColor);
                    break;
            }
        }
    }

}

