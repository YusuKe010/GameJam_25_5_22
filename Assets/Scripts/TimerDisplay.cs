using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class TimerDisplay : MonoBehaviour
{
    [SerializeField] Text timeText;// UI テキストへの参照
    private float elapsedTime = 0f;   // 経過時間

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        elapsedTime += Time.deltaTime;//経過時間を加算
        // Mathf.FloorToIntはfloatをintに変換
        int minutes = Mathf.FloorToInt(elapsedTime / 60F);//分に変換
        int seconds = Mathf.FloorToInt(elapsedTime % 60F);//秒に変換

        // UI テキストを更新
        timeText.text = $"Time {minutes}:{seconds}";

    }
}
