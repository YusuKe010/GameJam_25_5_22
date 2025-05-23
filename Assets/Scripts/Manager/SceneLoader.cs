using System;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using System.Collections;

public class SceneLoader : MonoBehaviour
{
    bool _enableControl = false;
    int _chooseButton;
    Transform _buttonX;
    //Transform _titleX;
    Image _blackfade;
    [SerializeField] AudioClip _startSE;
    [SerializeField] GameObject introduce;
    AudioSource _titleBGM;
    AudioSource _audiosource;
    GameObject[] selectButton;
    void Start()
    {
        GameObject BGM = GameObject.Find("Title BGM");
        GameObject blackFade = GameObject.Find("BlackFade");
        selectButton = GameObject.FindGameObjectsWithTag("Button");
        _titleBGM = BGM.GetComponent<AudioSource>();
        _audiosource = GetComponent<AudioSource>();
        _blackfade = blackFade.GetComponent<Image>();
        StartCoroutine("FadeIn");

    }
    IEnumerator FadeIn()
    {
        yield return new WaitForSeconds(0.1f);
        _blackfade.color = new Color32(0, 0, 0, 255);
        for (int i = 0; i < 51; i++)
        {
            _blackfade.color -= new Color32(0, 0, 0, 5);
            yield return new WaitForSeconds(0.01f);
        }
        //selectButton.transform.position = new Vector2(-1400, -150);
        _titleBGM.Play();
        _blackfade.enabled = false;
        //-1400 ¨ -600

        yield return new WaitForSeconds(1f);

        _enableControl = true;
        Debug.Log("ˆ—Š®—¹");
    }
    public void LoadScene(string name)
	{
        Debug.Log("ƒ{ƒ^ƒ“‚Í‰Ÿ‚³‚ê‚½‚Å");
		StartCoroutine(FadeOut(name));
	}

    IEnumerator FadeOut(string name)
    {
        _blackfade.enabled = true;

        for (int i = 0; i < 51; i++)
        {
            _blackfade.color += new Color32(0, 0, 0, 5);
            yield return new WaitForSeconds(0.05f);
        }
        for (int i = 0; i <= 10; i++)
        {
            _titleBGM.volume -= 0.1f;
            yield return new WaitForSeconds(0.05f);
        }
        yield return new WaitForSeconds(1f);
        SceneManager.LoadScene(name);

    }
}
