using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static Unity.VisualScripting.Member;

public class Jump : MonoBehaviour
{
    [SerializeField] private float jump = 15f;
    Rigidbody2D rb = default;
    bool isgrand=false;
    [SerializeField]
    private AudioSource source;
    [SerializeField] AudioClip clip;
    public bool IsGroud
    {
        // IsGroudを呼び出したときにisgrandを持ってくる
        get { return isgrand; }
    }
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();//Rigidbody2Dを読み込む
    }

    // Update is called once per frame
    void Update()
    {
        //Spaceを押したらjumpplayer関数を呼び出す
        if (Input.GetKeyDown(KeyCode.Space))
        {
            jumpplayer();
        }
    }

    public void jumpplayer()
    {
        //isground変数がtrueの場合ジャンプするよう力を加え、 isgrandをfalseにする
        if (isgrand)
        {
            rb.AddForce(Vector2.up * jump, ForceMode2D.Impulse);
            source.PlayOneShot(clip); //効果音を再生
            isgrand = false;
        }
    }
    //プレイヤーとものが当たっているか判定する
    private void OnCollisionEnter2D(Collision2D collision)
    {
        //当たったゲームオブジェクトのタグがGroundかDamage floorだったらisgrand変数をtrueにする
        if (collision.gameObject.tag == "Ground"|| collision.gameObject.tag == "Damage floor")
        {
            isgrand = true;
        } 
    }
}
