using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(AudioSource))]
public class MusicManager : MonoBehaviour
{
    [Header("Background music clips and audiosource")]
    public AudioClip mainMenuMusic;
    public AudioClip gameMusic;
    public AudioClip winMusic;
    public AudioClip tieMusic;
    public AudioSource backgroundMusic;

    [Header("Panels for different music")]
    public GameObject mainMenuScreen;
    public GameObject gameScreen;
    public GameObject overScreen;

    [Header("Volume Slider")]
    public Slider volumeSlider;

    public GameManager gm;

    private void Start()
    {
        backgroundMusic = GetComponent<AudioSource>();

        gm = FindObjectOfType<GameManager>();

        volumeSlider.value = backgroundMusic.volume;
        InvokeRepeating("VolumeChange", 0f, 0.03f);
        backgroundMusic.clip = mainMenuMusic;
    }

    public void MainMenuMusic()
    {
        backgroundMusic.clip = mainMenuMusic;
        backgroundMusic.Play();
        backgroundMusic.loop = true;
    }

    public void GameMusic()
    {
        backgroundMusic.clip = gameMusic;
        backgroundMusic.Play();
        backgroundMusic.loop = true;
    }

    public void OverMusic()
    {
        if (gm.tie)
        {
            backgroundMusic.clip = tieMusic;
            backgroundMusic.Play();
            backgroundMusic.loop = false;
        }

        else
        {
            backgroundMusic.clip = winMusic;
            backgroundMusic.Play();
            backgroundMusic.loop = false;
        }
    }

    public void VolumeChange()
    {
        backgroundMusic.volume = volumeSlider.value;
    }
}
