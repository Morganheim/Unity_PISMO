using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(AudioSource))]
public class MV2_3_MusicManager : MonoBehaviour
{
    public Slider volumeSlider;

    public AudioClip player1AudioClip;
    public AudioClip player2AudioClip;
    public AudioClip menuAudioClip;
    public AudioSource ass;

    public MV2_3_GameManager gm;

    private void Start()
    {
        gm = FindObjectOfType<MV2_3_GameManager>();
        ass = GetComponent<AudioSource>();
        InvokeRepeating("SetVolume", 0f, 0.03f);
    }

    public void MenuMusic()
    {
        ass.clip = menuAudioClip;
        ass.Play();
        ass.loop = true;
    }

    public void GameMusic()
    {
        if (gm.player1Playing)
        {
            ass.clip = player1AudioClip;
            ass.Play();
            ass.loop = true;
        }
        else
        {
            ass.clip = player2AudioClip;
            ass.Play();
            ass.loop = true;
        }
    }

    public void SetVolume()
    {
        ass.volume = volumeSlider.value;
    }
}
