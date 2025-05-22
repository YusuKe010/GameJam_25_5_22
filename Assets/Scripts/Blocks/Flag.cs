using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flag : MonoBehaviour
{
	private GameManger _gameManger;
	private void OnCollisionEnter2D(Collision2D other)
	{
		if (other.gameObject.CompareTag("Player"))
		{
			_gameManger = FindAnyObjectByType<GameManger>();
			_gameManger.GameCleear();
		}
	}
}
