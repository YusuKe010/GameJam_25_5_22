using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerColorManager : MonoBehaviour
{
    [SerializeField] PlayerColor _startColor;
    [SerializeField] PlayerInput _playerInput;
    GameManger _gameManager;
    // Start is called before the first frame update
    void Start()
    {
        _gameManager = FindAnyObjectByType<GameManger>();
        Material mat = this.GetComponent<Renderer>().material; // 現在使用されているマテリアルを取得 
        _gameManager.ChangePlayerColor(_startColor);
        switch (_startColor)
        {
            case PlayerColor.Red:
                GetComponent<SpriteRenderer>().color = Color.red;
                Debug.Log(_gameManager.PlayerColor);
                break;
            case PlayerColor.Blue:
                GetComponent<SpriteRenderer>().color = Color.blue;
                Debug.Log(_gameManager.PlayerColor);
                break;
            case PlayerColor.Yellow:
                GetComponent<SpriteRenderer>().color = Color.yellow;
                Debug.Log(_gameManager.PlayerColor);
                break;
            case PlayerColor.Green:
                GetComponent<SpriteRenderer>().color = Color.green;
                Debug.Log(_gameManager.PlayerColor);
                break;
            case PlayerColor.Purple:
                GetComponent<SpriteRenderer>().color = new Color(0.6f, 0, 1);
                Debug.Log(_gameManager.PlayerColor);
                break;
        }

        _playerInput.OnInputRightMouseClick += ChangeColor;
    }


    private void ChangeColor()
    {
        switch (_gameManager.PlayerColor)
        {
            case PlayerColor.Red:
                _gameManager.ChangePlayerColor(PlayerColor.Blue);
                GetComponent<SpriteRenderer>().color = Color.blue;
                Debug.Log(_gameManager.PlayerColor);
                break;
            case PlayerColor.Blue:
                _gameManager.ChangePlayerColor(PlayerColor.Yellow);
                GetComponent<SpriteRenderer>().color = Color.yellow;
                Debug.Log(_gameManager.PlayerColor);
                break;
            case PlayerColor.Yellow:
                _gameManager.ChangePlayerColor(PlayerColor.Green);
                GetComponent<SpriteRenderer>().color = Color.green;
                Debug.Log(_gameManager.PlayerColor);
                break;
            case PlayerColor.Green:
                _gameManager.ChangePlayerColor(PlayerColor.Purple);
                GetComponent<SpriteRenderer>().color = new Color(0.6f, 0, 1);
                Debug.Log(_gameManager.PlayerColor);
                break;
            case PlayerColor.Purple:
                _gameManager.ChangePlayerColor(PlayerColor.Red);
                GetComponent<SpriteRenderer>().color = Color.red;
                Debug.Log(_gameManager.PlayerColor);
                break;
        }
    }
}

