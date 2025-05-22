using UnityEngine;

public class GameManger : MonoBehaviour
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

	public void GameCleear()
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
