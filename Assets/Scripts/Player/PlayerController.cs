using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public bool IsGround = false;

    //�v���C���[�Ƃ��̂��������Ă��邩���肷��
    private void OnTriggerEnter2D(Collider2D collision)
    {
        //���������Q�[���I�u�W�F�N�g�̃^�O��Ground��Damage floor��������isgrand�ϐ���true�ɂ���
        if (collision.gameObject.tag == "Ground" || collision.gameObject.tag == "Damage floor")
        {
            IsGround = true;
            Debug.Log("GroundEnter");
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Ground" || collision.gameObject.tag == "Damage floor")
        {
            IsGround = false;
            Debug.Log("GroundExit");
        }
    }
}
