using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject prefab; // predmet koji se stvara
    public float timer = 3; //vremenski period za stvaranje objekta
    float timerReset; //Vraæanje timera na poèetnu vrijednost

    private void Start()
    {
        timerReset = timer;
    }

    private void Update()
    {
        timer -= Time.deltaTime;
        if (timer <= 0)
        {
            float randomPozcijaX = Random.Range(-6.7f, 6.7f);
            Instantiate(prefab, new Vector3(randomPozcijaX, 10, 0), Quaternion.identity);
            timer = timerReset;
        }
    }
}
