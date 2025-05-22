using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static Unity.VisualScripting.Member;

public class sound : MonoBehaviour
{
    [SerializeField]
    private AudioSource source; 
    [SerializeField] AudioClip clip;

    [SerializeField]
    private AudioClip clip1;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(1))
        {
            source.clip = clip1; //Ä¶‚µ‚½‚¢clip‚ğw’è‚µ‚Ä
            source.PlayOneShot(clip); //Ä¶
        }
    }
}
