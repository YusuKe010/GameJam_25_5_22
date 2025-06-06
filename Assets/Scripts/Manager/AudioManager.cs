using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    [SerializeField]
    private AudioSource _BGMsource;
    [SerializeField]
    private AudioSource _SEsource;

    public void PlayBGM(AudioClip BGM)
    {
        _BGMsource.PlayOneShot(BGM);
    }
    
    public void PlaySE(AudioClip audio)
    {
        _SEsource.PlayOneShot(audio);
    }

    public void StopBGM()
    {
        _BGMsource.Stop();
    }

    public void LoopOFF()
    {
        _BGMsource.loop = false;
    }
    public void LoopON()
    {
        _BGMsource.loop = true;
    }
}
