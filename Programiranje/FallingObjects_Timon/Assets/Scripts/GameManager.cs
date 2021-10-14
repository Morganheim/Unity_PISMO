using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public int score = 0; //broj bodova
    public int life = 3; //broj zivota

    public AudioClip coin;
    public AudioClip boom;
    public AudioSource collect;

    public Text scoreText;
    public Text lifeText;

    private void Start()
    {
        scoreText.text = "Score: " + score;
        lifeText.text = "Life: " + life + "/3";
    }

    private void Update()
    {
        //Na escape ugasi igru
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
        }

        //testiranje da je igra pauzirana
        //Debug.Log(Time.deltaTime);
    }

    public void DodajScore()
    {
        score++;
        collect.clip = coin;
        collect.Play();

        scoreText.text = "Score: " + score;
        //scoreText.text = score + "";
        //scoreText.text = score.ToString();

        Debug.Log("<color=green>Score is: " + score + "</color> and <color=red> life is: " + life + "</color>");
    }

    public void MakniZivot()
    {
        life--;
        collect.clip = boom;
        collect.Play();

        lifeText.text = "Life: " + life + "/3";

        Debug.Log("<color=green>Score is: " + score + "</color> and <color=red> life is: " + life + "</color>");
        if (life <= 0)
        {
            Debug.Log("<color=red>Izgubio si. Konacni score je: " + score + "</color>");
            Application.Quit();
            Destroy(this.gameObject);
        }
    }

    public void ExitGame() //metoda koja je na gumbu (button) za izaci iz igre
    {
        Application.Quit();
        Debug.Log("Quitting game");
    }

    public void PauseGame()
    {
        Time.timeScale = 0;
        Debug.Log("Game paused");
    }

    public void ResumeGame()
    {
        Time.timeScale = 1;
    }
}
