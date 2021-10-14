using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(AudioSource))]
public class ClickerManager : MonoBehaviour
{
    public AudioSource ass;
    public AudioClip clickSound;

    [Header("Volume Slider")]
    public Slider volumeSlider;

    private void Start()
    {
        ass = GetComponent<AudioSource>();

        volumeSlider.value = ass.volume;
        InvokeRepeating("VolumeChange", 0f, 0.03f);
    }

    public void ClickSound()
    {
        ass.clip = clickSound;
        ass.Play();
    }

    public void VolumeChange()
    {
        ass.volume = volumeSlider.value;
    }
}
