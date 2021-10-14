using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public int score;
    public GameObject[] coins;

    public UIManager uiM;

    private void Start()
    {
        uiM = FindObjectOfType<UIManager>();
    }


    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Coin")
        {
            ScoreUp();
            other.gameObject.SetActive(false);

            if (score == coins.Length)
            {
                uiM.GameWon(score);
                Time.timeScale = 0;
            }
        }
    }

    public void ScoreUp()
    {
        score++;
        uiM.UpdateScore(score, coins.Length);
    }
}
