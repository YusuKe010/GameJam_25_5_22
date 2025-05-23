using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flag : MonoBehaviour
{
	BoxCollider2D collider2D;
	private GameManager _gameManger;
	private void OnCollisionEnter2D(Collision2D other)
	{
		collider2D = GetComponent<BoxCollider2D>();
		if (other.gameObject.CompareTag("Player"))
		{
			collider2D.enabled = false;
			_gameManger = FindAnyObjectByType<GameManager>();
			_gameManger.GameClear();
		}
	}
}
