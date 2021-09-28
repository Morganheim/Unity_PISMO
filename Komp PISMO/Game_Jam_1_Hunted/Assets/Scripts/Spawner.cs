using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject[] prefabsPlatforme; // predmet koji se stvara
    [Range(0.5f, 10)]
    public float timer; //vremenski period za stvaranje objekta
    float timerReset; //Vraæanje timera na poèetnu vrijednost
    int brojStvorenih;

    private void Start()
    {
        timerReset = timer;
        float randomPozcijaX = Random.Range(-9f, 9f);
        Instantiate(prefabsPlatforme[Random.Range(0, prefabsPlatforme.Length)], new Vector3(randomPozcijaX, 25, 0), Quaternion.identity);
        brojStvorenih++;
    }

    private void Update()
    {
        timer -= Time.deltaTime;
        if (timer <= 0)
        {
            float randomPozcijaX = Random.Range(-9f, 9f);
            Instantiate(prefabsPlatforme[Random.Range(0, prefabsPlatforme.Length)], new Vector3(randomPozcijaX, 25, 0), Quaternion.identity);
            brojStvorenih++;
            timer = timerReset;
        }

        
    }
}
