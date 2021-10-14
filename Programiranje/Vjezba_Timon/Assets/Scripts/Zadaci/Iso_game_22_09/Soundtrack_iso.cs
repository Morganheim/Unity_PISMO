using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Soundtrack_iso : MonoBehaviour
{
    public AudioClip backgroundMusic;

    public AudioSource ost;

    private void Start()
    {
        ost = GetComponent<AudioSource>();
        ost.clip = backgroundMusic;
        ost.Play();
        ost.loop = true;
    }
}
