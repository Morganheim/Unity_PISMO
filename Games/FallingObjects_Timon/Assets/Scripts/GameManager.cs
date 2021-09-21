using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public int score = 0; //broj bodova
    public int life = 3; //broj zivota

    private void Update()
    {
        //Na escape ugasi igru
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

    public void MakniZivot()
    {
        life--;
        Debug.Log("<color=green>Score is: " + score + "</color> and <color=red> life is: " + life + "</color>");
        if (life <= 0)
        {
            Debug.Log("<color=red>Izgubio si. Konaèni score je: " + score + "</color>");
            Application.Quit();
            Destroy(this.gameObject);
        }
    }
}
