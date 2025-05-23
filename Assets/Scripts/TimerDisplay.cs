using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class TimerDisplay : MonoBehaviour
{
    [SerializeField] Text timeText;// UI �e�L�X�g�ւ̎Q��
    private float elapsedTime = 0f;   // �o�ߎ���

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        elapsedTime += Time.deltaTime;//�o�ߎ��Ԃ����Z
        // Mathf.FloorToInt��float��int�ɕϊ�
        int minutes = Mathf.FloorToInt(elapsedTime / 60F);//���ɕϊ�
        int seconds = Mathf.FloorToInt(elapsedTime % 60F);//�b�ɕϊ�

        // UI �e�L�X�g���X�V
        timeText.text = $"Time {minutes}:{seconds}";

    }
}
