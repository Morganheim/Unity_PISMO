using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AS_Zad_02 : MonoBehaviour
{
    public AudioSource ass;

    private void Start()
    {
        ass = GetComponent<AudioSource>();
    }

    private void Update()
    {
        if (ass.isPlaying == true)
        {
            ass.Stop();
        }
        else if (ass.isPlaying == false)
        {
            ass.Play();
        }
    }
}
