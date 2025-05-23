using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHpUI : MonoBehaviour
{
    [SerializeField] Text _stocktext;
    [SerializeField] PlayerHealth _health;

    private void Start()
    {
        changetext($"Å~{_health.MaxHP}");
        _health.OnTakeDamage += changetext;
    }

    public void changetext(string text)
    {
        _stocktext.text = text;
    }
}
