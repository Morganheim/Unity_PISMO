using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour
{
    public GameObject[] sviObjekti;
    public GameObject player;

    public Text scoreText;
    public Text controlsText;

    public GameObject endGamePanel;
    public Text gameOverText;

    public void UpdateText(int kolkoImamo, int kolkoJeMax)
    {
        scoreText.text = kolkoImamo + "/" + kolkoJeMax;
    }

    public void RestartGame()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(0);
    }

    public void ExitGame()
    {
        Application.Quit();
    }

    public void PauseGame()
    {
        Time.timeScale = 0;
    }

    public void ResumeGame()
    {
        Time.timeScale = 1;
    }

    public void StartGame()
    {
        for(int i = 0; i < sviObjekti.Length; i++)
        {
            sviObjekti[i].SetActive(true);
        }
        player.gameObject.SetActive(true);
    }

    public void GameOver(int scoreFinal)
    {
        for (int i = 0; i < sviObjekti.Length; i++)
        {
            sviObjekti[i].SetActive(false);
        }
        
        endGamePanel.SetActive(true);
        gameOverText.text = "Your score is: " + (int)(scoreFinal);
    }
}
