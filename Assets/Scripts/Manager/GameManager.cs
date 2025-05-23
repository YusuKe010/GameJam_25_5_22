using UnityEngine;

public class GameManager : MonoBehaviour
{
	private PlayerColor playerCoplor = PlayerColor.Red;

	public PlayerColor PlayerColor
	{
		get { return playerCoplor; }
	}

	public void ChangePlayerColor(PlayerColor color)
	{
		playerCoplor = color;
	}

	public void GameClear()
	{
		FindAnyObjectByType<SceneLoader>().LoadScene("GameClear");
	}
}

public enum PlayerColor
{
	Red,
	Green,
	Blue,
	Yellow,
	Purple
}
