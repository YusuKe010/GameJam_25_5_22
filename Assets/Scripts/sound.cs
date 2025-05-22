using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static Unity.VisualScripting.Member;

public class sound : MonoBehaviour
{
    [SerializeField]
    private AudioSource source; 
    [SerializeField] AudioClip clip;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(1))
        {
            source.PlayOneShot(clip); //çƒê∂
        }
    }
}
