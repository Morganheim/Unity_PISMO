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
        coins = GameObject.FindGameObjectsWithTag("Coin");
        uiM.UpdateText(score, coins.Length);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Coin")
        {
            score++;
            other.gameObject.SetActive(false);
            uiM.UpdateText(score, coins.Length);
            
           
        }
        if(other.gameObject.tag=="Finish")
        {
            uiM.GameOver(score);
            Time.timeScale = 0;
            //GameObject player = GameObject.FindGameObjectWithTag("Player");
            //player.SetActive(false);
        }

    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Die")
        {
            Debug.Log("Ded");
            Time.timeScale = 0;
            uiM.GameOver(score);
        }
    }
}
