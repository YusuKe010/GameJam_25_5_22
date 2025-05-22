using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonIC : MonoBehaviour
{
    [SerializeField] GameObject _image;
    public void OnButtonEnter()
    {
        _image.SetActive(true);
    }

    public void OnButtonExit()
    {
        _image.SetActive(false);
    }
}
