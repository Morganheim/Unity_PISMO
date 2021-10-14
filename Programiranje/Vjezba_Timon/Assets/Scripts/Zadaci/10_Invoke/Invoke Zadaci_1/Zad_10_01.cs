using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Zad_10_01 : MonoBehaviour
{
    public Text timerText;

    public int minutes;
    public int seconds;

    public float timer;

    private void Start()
    {
        timer = 0;

        InvokeRepeating("Sat", 0f, 1f);
    }

    void Sat()
    {
        timer++;
        minutes = (int)timer / 60;
        seconds = (int)timer % 60;

        if (timer >= 0 && timer < 3600)
        {
            if (minutes < 10 && seconds < 10)
            {
                timerText.text = "0" + minutes + ":" + "0" + seconds;
            }

            else if (minutes >= 10 && seconds < 10)
            {
                timerText.text = minutes + ":" + "0" + seconds;
            }

            else if (minutes >= 10 && seconds >= 10)
            {
                timerText.text = minutes + ":" + seconds;
            }

            else if (minutes < 10 && seconds >= 10)
            {
                timerText.text = "0" + minutes + ":" + seconds;
            }
        }
        else if (timer < 0 || timer >= 3600)
        {
            timerText.text = "Izvan vremenskog okvira.";
        }
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            timer -= 300;
        }
    }
}
