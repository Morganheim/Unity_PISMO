using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public Text scoreText;
    public Text timerText;

    public int minutes;
    public int seconds;
    public float allTime;

    //ova skripta sluzi za novo postavljanje texta kada se vrijednosti promijene
    public void UpdateText(int kolkoImamo, int kolkoJeMax)
    {
        scoreText.text = kolkoImamo + "/" + kolkoJeMax;
    }

    private void Update()
    {
        //vrti se update ali na timer tex se iskljucivo prikazuje vrijeme, npr.
        //00:05, 00:14, 00:59, 01:02, 02:24, 12:53, dakle minute i sekunde
        allTime += Time.deltaTime;
        minutes = (int)allTime / 60;
        seconds = (int)allTime % 60;

        if (minutes < 10 && seconds < 10)
        {
            timerText.text = "0"+minutes + ":" + "0" + seconds;
        }
        else if (minutes < 10 && seconds >= 10)
        {
            timerText.text = "0" + minutes + ":" + seconds;
        }
        else if (minutes >= 10 && seconds < 10)
        {
            timerText.text = minutes + ":" + "0" + seconds;
        }
        else
        {
            timerText.text = minutes + ":" + seconds;
        }
    }
}
