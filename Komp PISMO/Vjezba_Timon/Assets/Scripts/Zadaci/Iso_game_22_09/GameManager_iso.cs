using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager_iso : MonoBehaviour
{
    public int score;
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

        Debug.Log("<color=green>Score is: " + score + "</color> and <color=red> life is: " + life + "</color>");
    }

    public void MakniLife()
    {
        life--;

        Debug.Log("<color=green>Score is: " + score + "</color> and <color=red> life is: " + life + "</color>");
        if (life <= 0)
        {
            Debug.Log("<color=red>Izgubio si. Konacni score je: " + score + "</color>");
            Application.Quit();
            Destroy(this.gameObject);
        }
    }
}
