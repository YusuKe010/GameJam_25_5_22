using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;

/// <summary>
/// �y�w�i�̃R���g���[���p�N���X�z
///     �w�i��3���A�J�������猩�؂ꂽ���荞��
/// </summary>
public class BackGroundController : MonoBehaviour
{
    [SerializeField] Transform[] backGrounds;
    [SerializeField] Transform player;

    [SerializeField] float width;
    [SerializeField] float moveScale = 0.2f;

    Vector3 savePlayerPos;

    private void Start()
    {
        savePlayerPos = player.position;
    }


    private void Update()
    {
        Vector3 delta = player.position - savePlayerPos;
        // �w�i�X�N���[���i�S�̂𓮂����j
        foreach (var bg in backGrounds)
        {
            bg.position += new Vector3(delta.x * moveScale, 0f, 0f);
        }

        for (int i = 0; i < backGrounds.Length; i++)
        {
            float distanceFromPlayer = backGrounds[i].position.x - player.position.x;
            if (distanceFromPlayer < -width * 1.5f)
            {
                backGrounds[i].position += new Vector3(width * backGrounds.Length, 0, 0);
            }
            else if (distanceFromPlayer > width * 1.5f)
            {
                backGrounds[i].position -= new Vector3(width * backGrounds.Length, 0, 0);
            }


        }
        savePlayerPos = player.position;
    }
}