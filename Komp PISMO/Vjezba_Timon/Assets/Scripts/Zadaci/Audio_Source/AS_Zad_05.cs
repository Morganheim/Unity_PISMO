using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AS_Zad_05 : MonoBehaviour
{
    public AudioSource ass;

    private void Start()
    {
        ass = GetComponent<AudioSource>();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.S))
        {
            ass.Play();
        }
        if (Input.GetKeyDown(KeyCode.P))
        {
            ass.Pause();
        }
        if (Input.GetKeyDown(KeyCode.U))
        {
            ass.UnPause();
        }
        if (Input.GetKeyDown(KeyCode.M))
        {
            ass.mute = !ass.mute;
        }
        if (Input.GetKeyDown(KeyCode.T))
        {
            ass.Stop();
        }
    }
}
