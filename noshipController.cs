using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class noshipController : MonoBehaviour
{
    AudioSource audio;
    MeshRenderer display;
    // Start is called before the first frame update
    void Start()
    {
        audio = GetComponent<AudioSource>();
        audio.Stop();
        display = GetComponent<MeshRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnMouseDown ()
    {
       audio.Play();
       display.enabled = false;
       print("ТЫ промазал");
    }
}
