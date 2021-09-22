using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager_iso : MonoBehaviour
{
    public int score;
    public int scoreCounter;
    public int life = 5;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
        }
    }

    public void DodajScore()
    {
        score++;
        scoreCounter++;
        Debug.Log("<color=green>Score je: " + score + "</color> i <color=red> life je: " + life + "</color>");
    }

    public void MakniLife()
    {
        life--;

        Debug.Log("<color=green>Score je: " + score + "</color> i <color=red> life je: " + life + "</color>");
        if (life <= 0)
        {
            Debug.Log("<color=red>Izgubio si. Konacni score je: " + score + "</color>");
            Destroy(this.gameObject);
        }
    }
}
