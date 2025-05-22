using UnityEngine;

public class GameManger : MonoBehaviour
{
	private PlayerColor playerCoplor;

	public PlayerColor PlayerColor
	{
		get { return playerCoplor; }
	}

	public void ChangePlayerColor(PlayerColor color)
	{
		playerCoplor = color;
	}

	public void GameOver()
	{
		FindAnyObjectByType<SceneLoader>().LoadScene("GameOver");
	}
}

public enum PlayerColor
{
	Red,
	Green,
	Blue,
	Yellow
}
