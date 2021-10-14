using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Zad_09_01 : MonoBehaviour
{
    public Text timerText;

    public int minutes;
    public int seconds;

    public float timer;

    private void Start()
    {
        timer = Time.deltaTime;
        StartCoroutine(Sat());
    }

    IEnumerator Sat()
    {
        while (timer >= 0 && timer < 3600)
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

            yield return new WaitForSeconds(1);
        }
    }

    private void Update()
    {
        timer += Time.deltaTime;
        minutes = (int)timer / 60;
        seconds = (int)timer % 60;

        if (timer < 0 || timer >= 3600)
        {
            StopCoroutine(Sat());
            timerText.text = "Izvan vremenskog okvira.";
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            timer -= 300;
        }
    }
}
