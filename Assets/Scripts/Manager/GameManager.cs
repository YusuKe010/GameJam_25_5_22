using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    [SerializeField] Image _blackfade;
    [SerializeField] AudioClip clearJingle;
    [SerializeField] AudioManager audioManager;

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
        audioManager.StopBGM();
        audioManager.LoopOFF();
        audioManager.PlayBGM(clearJingle);

        StartCoroutine("FadeOut");
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
        yield return new WaitForSeconds(7f);
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
