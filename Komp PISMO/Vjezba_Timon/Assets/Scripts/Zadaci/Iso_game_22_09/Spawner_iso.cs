using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner_iso : MonoBehaviour
{
    public GameManager_iso gm;

    public GameObject[] enemies;
    public GameObject[] spawnPoints;
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
            Instantiate(enemies[Random.Range(0, enemies.Length)], , Quaternion.identity);
            timer = timerReset;

            if(gm.score %10 == 0)
            {

            }
        }
    }













}
