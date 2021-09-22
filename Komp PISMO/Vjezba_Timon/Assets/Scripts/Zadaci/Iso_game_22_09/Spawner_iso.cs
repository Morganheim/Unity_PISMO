using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner_iso : MonoBehaviour
{
    public GameManager_iso gm;

    public GameObject[] enemies;
    public Transform[] spawnPoints;

    public float timer;
    float timerReset;

    private void Start()
    {
        gm = FindObjectOfType<GameManager_iso>();
        timerReset = timer;
    }

    private void Update()
    {
        timer -= Time.deltaTime;
        if (timer <= 0)
        {
            Instantiate(enemies[Random.Range(0, enemies.Length)], spawnPoints[Random.Range(0, spawnPoints.Length)].position, Quaternion.identity);

            Debug.Log("timerReset je " + timerReset + "Score je " + gm.score + "Score Counter je " + gm.scoreCounter);

            if (gm.score == 10)
            {
                timerReset *= 0.85f;
            }


            if (gm.score > 0 && timerReset >= 0.5f)
            {
                if (gm.scoreCounter % 10 == 0)
                {
                    timerReset *= 0.85f;
                    timer = timerReset;
                    gm.scoreCounter = 0;
                }
            }

            //if(gm.score % 10 == 0 && gm.score > 0 && timerReset >= 0.5f)
            //{
            //    timerReset *= 0.85f;
            //    timer = timerReset;
            //}

            timer = timerReset;
        }

        if (gm.life <= 0)
        {
            Destroy(this);
        }
    }
}
