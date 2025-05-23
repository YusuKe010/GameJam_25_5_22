using UnityEngine;
using System.Collections;

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
    IEnumerator FadeIn()
    {
        _blackfade.color = new Color32(0, 0, 0, 255);
        for (int i = 0; i < 51; i++)
        {
            _blackfade.color -= new Color32(0, 0, 0, 5);
            yield return new WaitForSeconds(0.01f);
        }
    }

    IEnumerator FadeOut()
    {
        for (int i = 0; i < 51; i++)
        {
            _blackfade.color += new Color32(0, 0, 0, 5);
            yield return new WaitForSeconds(0.05f);
        }
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
