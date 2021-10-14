using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour
{
    public GameManager gm;

    public GameObject winPanel;
    public Text winText;

    [Header("Timer")]
    public int minutes;
    public int seconds;
    public float allTime;

    [Header("UI Settings")]
    public Text scoreText;
    public Text timerText;

    private void Start()
    {
        gm = FindObjectOfType<GameManager>();
        allTime = gm.coins.Length * 45;
    }

    private void Update()
    {
        allTime -= Time.deltaTime;
        minutes = (int)(allTime / 60);
        seconds = (int)(allTime % 60);

        if (minutes < 10 && seconds < 10)
        {
            timerText.text = "0" + minutes + ":" + "0" + seconds;
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

    public void UpdateScore(int skupljeniCoins, int maxCoins)
    {
        scoreText.text = skupljeniCoins + "/" + maxCoins;
    }

    public void GameWon(int finalScore)
    {
        winPanel.SetActive(true);
        float winScore = (finalScore * allTime);
        winText.text = "Your score is: " + (int)(winScore);
    }

    public void RestartGame()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(0);
    }

    public void ExitGame()
    {
        Application.Quit();
        Debug.Log("Game Exited.");
    }
}
