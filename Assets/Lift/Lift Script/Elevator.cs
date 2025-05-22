using UnityEngine;

public class Elevator : MonoBehaviour
{
    // ���������g�����́A�ȉ��̂悤�Ɂu�v���C���[�� "������" �ɏ������v���C���[�� "������" �̎q�I�u�W�F�N�g�ɂ���v�Ƃ����������K�v�ł��B
    // �ȉ��̏������R�����g�A�E�g����ƁA�������ɏ�������Ƀv���C���[�����ɂ߂荞�ނ��Ƃ��킩��ł��傤�B

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag.Equals("Player"))
        {
            collision.gameObject.transform.SetParent(this.transform);
        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.tag.Equals("Player"))
        {
            collision.gameObject.transform.SetParent(null);
        }
    }
}
