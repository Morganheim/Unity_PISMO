using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public int score = 0; //broj bodova
    public int life = 3; //broj zivota

    public AudioClip coin;
    public AudioClip boom;
    public AudioSource collect;

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
        collect.clip = coin;
        collect.Play();
        Debug.Log("<color=green>Score is: " + score + "</color> and <color=red> life is: " + life + "</color>");
    }

    public void MakniZivot()
    {
        life--;
        collect.clip = boom;
        collect.Play();
        Debug.Log("<color=green>Score is: " + score + "</color> and <color=red> life is: " + life + "</color>");
        if (life <= 0)
        {
            Debug.Log("<color=red>Izgubio si. Konacni score je: " + score + "</color>");
            Application.Quit();
            Destroy(this.gameObject);
        }
    }
}
