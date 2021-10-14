using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class Zadatak_13 : MonoBehaviour
{
    AudioSource ass;
    public AudioClip muzika;

    private void Start()
    {
        ass = GetComponent<AudioSource>();
        ass.loop = true;
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.K) || Input.GetMouseButtonDown(0))
        {
            ass.Play();
        }
    }
}
