using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public GameObject[] sceneObjekti;
    public GameObject player;

    public GameObject deathMenu;
    public bool dead = false;

    public Text lifeText;
    public Text scoreText;
    public Text deathText;

    public int life;
    int maxLife = 5;

    public int score;

    public float timerRest;
    public float timer;

    private void Start()
    {
        timer = timerRest;

        life = maxLife;
    }

    public void LoseLife()
    {
       life--;
        lifeText.text = "Life: " + life + "/" + maxLife;
        if (life <= 0)
        {
            DeathGame();
        }
    }

    public void ScoreUp()
    {
        score++;
        scoreText.text = "Score: " + score;
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
        for (int i = 0; i < sceneObjekti.Length; i++)
        {
            sceneObjekti[i].SetActive(true);
        }
        player.gameObject.SetActive(true);
    }

    public void DeathGame()
    {
        for (int i = 0; i < sceneObjekti.Length; i++)
        {
            sceneObjekti[i].SetActive(false);
        }
        player.gameObject.SetActive(false);
        deathMenu.gameObject.SetActive(true);
        dead = true;
        deathText.text = "You died. Your final score is: " + score;
    }

    public void SetLife()
    {

    }
}
