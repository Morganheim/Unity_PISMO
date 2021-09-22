using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject[] prefabs; // predmet koji se stvara
    [Range(0.5f, 10)]
    public float timer; //vremenski period za stvaranje objekta
    float timerReset; //Vraæanje timera na poèetnu vrijednost
    int brojStvorenih;

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
            Instantiate(prefabs[Random.Range(0, prefabs.Length)], new Vector3(randomPozcijaX, 10, 0), Quaternion.identity);
            brojStvorenih++;
            timer = timerReset;
        }

        //nakon svakih 10 stvorenih neka se ubrza timer stvaranja za 10%, dakle npr.
        //na pocetku je 10 sekundi, poslije 10 stvorenih je 9 sekundi, onda se opet 10 stvori pa je
        //8.1 sekunda, pa opet se 10 stvori pa je onda 7.29 sekundi itd.
        //sa minimalnim timerom od 0.5 sekundi intervalom

        if (brojStvorenih == 10 && timerReset >= 0.5f)
        {
            timerReset *= 0.9f;
            brojStvorenih = 0;
        }
    }
}
