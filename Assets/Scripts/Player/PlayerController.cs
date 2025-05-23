using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public bool IsGround = false;

    //プレイヤーとものが当たっているか判定する
    private void OnTriggerEnter2D(Collider2D collision)
    {
        //当たったゲームオブジェクトのタグがGroundかDamage floorだったらisgrand変数をtrueにする
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
