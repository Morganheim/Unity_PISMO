using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour
{
    [Header("UI objects")]
    public Text scoreText;
    public Text timerText;

    [Header("Time data - do not change")]
    public int minutes;
    public int seconds;
    public float allTime;

    [Header("End game panel objects")]
    public GameObject endGamePanel;
    public Text endGameScoreText;

    //Ova skritpa sluzi za novo postavljanje texta kada se vrijednosti promjene
    public void UpdateText(int kolkoImamo, int kolkoJeMax)
    {
        scoreText.text = kolkoImamo + "/" + kolkoJeMax;
    }

    private void Update()
    {
        //Vrti se update, ali na timerText se iskljucivo prikazuje vrijeme npr.
        // 00:05, 00:14, 00:59, 01:02, 02:24, 12:53 dakle minute i sekunde
        allTime += Time.deltaTime;
        minutes = (int)(allTime / 60);
        seconds = (int)(allTime % 60);

        //Manje od 10 i sekunde i minute
        if (minutes < 10 && seconds < 10)
        {
            timerText.text = "0" + minutes + ":" + "0" + seconds;
        }

        //Minute manje od 10 a sekunde vece od 10

        else if (minutes < 10 && seconds >= 10)
        {
            timerText.text = "0" + minutes + ":" + seconds;
        }

        //Minute vece od 10 a sekunde manje od 10

        else if (minutes >= 10 && seconds < 10)
        {
            timerText.text = minutes + ":" + "0" + seconds;
        }

        //Minute i sekunde su vece od 10
        else
        {
            timerText.text = minutes + ":" + seconds;
        }
    }

    public void ShowEndGame(int brojArtifakta)
    {
        endGamePanel.SetActive(true);
        float endGameScore = (brojArtifakta / allTime) * 100000;
        endGameScoreText.text = "Your score is: " + (int)(endGameScore);
    }

    public void PlayAgain()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(0);
    }

    public void ExitGame()
    {
        Application.Quit();
    }
}
