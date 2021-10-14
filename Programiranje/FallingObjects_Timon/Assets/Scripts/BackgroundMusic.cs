using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundMusic : MonoBehaviour
{
    public AudioClip soundtrack;
    public AudioSource background;

    private void Start()
    {
        background.clip = soundtrack;
        background.Play();
    }
}
