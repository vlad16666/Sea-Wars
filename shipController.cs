using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shipController : MonoBehaviour
{
    AudioSource audio;
    MeshRenderer display;
    static int score = 0;
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
    score = score + 1;
       audio.Play();
       display.enabled = false;
       print("Ты попал!");
       if(score == 4){
            print("ТЫ подбил все корабли!");
        }
    }
}
