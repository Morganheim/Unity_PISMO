using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager_iso : MonoBehaviour
{
    public GameObject[] sceneObjekti;

    public GameObject player;

    public int score;
    public int scoreCounter;
    public int life;
    public int maxLife = 5;

    public Text lifeText;
    public Text scoreText;
    public Text deathText;

    public GameObject deathMenu;

    private void Start()
    {
        life = maxLife;

        scoreText.text = "Score: " + score;
        lifeText.text = "Life: " + life + "/" + maxLife;
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            PauseGame();
        }
    }

    public void DodajScore()
    {
        score++;
        scoreCounter++;
        scoreText.text = "Score: " + score;
        Debug.Log("<color=green>Score je: " + score + "</color> i <color=red> life je: " + life + "</color>");
    }

    public void MakniLife()
    {
        life--;
        lifeText.text = "Life: " + life + "/5";
        Debug.Log("<color=green>Score je: " + score + "</color> i <color=red> life je: " + life + "</color>");
        if (life <= 0)
        {
            Debug.Log("<color=red>Izgubio si. Konacni score je: " + score + "</color>");
            DeathGame();
        }
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
        for(int i = 0; i < sceneObjekti.Length; i++)
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
        deathText.text = "You died. Your final score is: " + score;
    }
}
