using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bombController : MonoBehaviour
{
    AudioSource audio;
    MeshRenderer display;
    static int scor = 0;
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
        scor = scor + 1;
       audio.Play();
       display.enabled = false;
       print("ТЫ напоролся на мину");
        if(scor == 3){
            print("ТЫ проиграл");
        }
    }
}
