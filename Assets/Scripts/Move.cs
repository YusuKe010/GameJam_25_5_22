using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    [SerializeField] float speed = 1f;
    [SerializeField] float fall = 1f;
    Jump Jump = default;
    // Start is called before the first frame update
    void Start()
    {
       Jump= GetComponent<Jump>();
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.D))
        {
            transform.position += speed * Vector3.right * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.position -= speed * Vector3.right * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.position -= new Vector3(0, fall * Time.deltaTime, 0);
        }
        if(Input.GetKeyDown(KeyCode.W))
        {
            Jump.jumpplayer();
        }
    }
}
