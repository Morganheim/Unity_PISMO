using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_Sounds_iso : MonoBehaviour
{
    public AudioClip scoreUp;
    public AudioClip lifeDown;

    public AudioSource sounds;

    private void Start()
    {
        sounds = GetComponent<AudioSource>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Wall")
        {
            sounds.clip = scoreUp;
            sounds.Play();
        }

        if (collision.gameObject.tag == "Player")
        {
            sounds.clip = lifeDown;
            sounds.Play();
        }
    }
}
