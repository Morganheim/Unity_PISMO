using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wall_Sound : MonoBehaviour
{
    public AudioClip wallSound;
    public AudioSource wallAudio;

    private void Start()
    {
        wallAudio = GetComponent<AudioSource>();
        wallAudio.clip = wallSound;
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            wallAudio.Play();
        }
    }
}
