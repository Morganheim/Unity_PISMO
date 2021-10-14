using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AS_Zad_03 : MonoBehaviour
{
    public AudioSource ass;

    private void Start()
    {
        ass = GetComponent<AudioSource>();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.M))
        {
            ass.mute = true;
        }
        if (Input.GetKeyDown(KeyCode.K))
        {
            ass.mute = false;
        }
    }
}
