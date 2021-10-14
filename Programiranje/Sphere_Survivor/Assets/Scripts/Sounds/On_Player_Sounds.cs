using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class On_Player_Sounds : MonoBehaviour
{
    public AudioClip killSound;
    public AudioSource playerAudio;

    private void Start()
    {
        playerAudio = GetComponent<AudioSource>();
        playerAudio.clip = killSound;
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            playerAudio.Play();
        }
    }
}
