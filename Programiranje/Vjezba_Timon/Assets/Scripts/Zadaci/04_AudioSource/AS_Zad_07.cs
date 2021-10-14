using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AS_Zad_07 : MonoBehaviour
{
    public AudioClip glasan;
    public AudioClip tisi;
    public AudioSource audioS;

    [Range(0,1)]
    public float glasanVol;
    [Range(0,1)]
    public float tisiVol;

    private void Start()
    {
        audioS = GetComponent<AudioSource>();

    }

    private void Update()
    {


        if (Input.GetKeyDown(KeyCode.Alpha5) || Input.GetKeyDown(KeyCode.Keypad5))
        {
            audioS.clip = glasan;
            audioS.volume = 1;
            audioS.Play();
        }
        if (Input.GetKeyDown(KeyCode.P))
        {
            audioS.clip = tisi;
            audioS.volume = 0.5f;
            audioS.Play();
        }


    }
}
