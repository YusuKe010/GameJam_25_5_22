using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    [SerializeField] private Transform _respawnPoint;
    [SerializeField] private AudioManager _audioManager;
    [SerializeField] private AudioClip _takeDamageSE;
    [SerializeField] private AudioClip _dethSE;
    [SerializeField] private PlayerHpUI _playerHpUI;
    [SerializeField] private int _maxHP = 10;
    public int MaxHP
    {
        get { return _maxHP; }
    }
    
    private int _currentHP;
    public int CurrrentHP
    {
        get { return _currentHP; }
    }

    public event Action<string> OnTakeDamage;
    public event Action OnDeth;


    void Start()
    {
        _currentHP = _maxHP;
        _playerHpUI.updatelife("");
    }

    public void TakeDamege(int amount)
    {
        _currentHP -= amount;

        if (_currentHP <= 0)
        {
            _currentHP = 0;
            Respawn();
        }
        _audioManager.PlaySE(_takeDamageSE);
        OnTakeDamage?.Invoke($"~{_currentHP}");
    }
    private void Respawn()
    {
        if (_respawnPoint != null)
        {
            transform.position = _respawnPoint.position;
            _currentHP = _maxHP;
            _audioManager.PlaySE(_dethSE);

            OnDeth?.Invoke();
        }
    }
}
