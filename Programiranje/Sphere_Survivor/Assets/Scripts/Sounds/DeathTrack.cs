using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathTrack : MonoBehaviour
{
    public Soundtrack ost;

    public GameManager gm;

    public AudioClip deathSound;
    public AudioSource deathTrack;

    private void Start()
    {
        gm = FindObjectOfType<GameManager>();
        ost = FindObjectOfType<Soundtrack>();

        deathTrack = GetComponent<AudioSource>();
        deathTrack.clip = deathSound;
    }

    private void Update()
    {
        if (gm.dead)
        {
            ost.ost.Stop();
            deathTrack.Play();
            deathTrack.loop = true;
            gm.dead = false;
        }
    }
}
