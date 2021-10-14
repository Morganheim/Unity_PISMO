using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ARR_spec_zadatak : MonoBehaviour
{
    [Header("Dodijeliti prefabe charactera koji se trebaju stvarati")]
    public GameObject[] characters;
    [Header("Dodijeliti empty game objecte samo sa transformom zbog lokacije")]
    public Transform[] spawnPositions;
    [Header("Poèetno vrijeme do spawna charactera")]
    [Range(1, 5)]
    public float timer;

    float timerReset;

    private void Start()
    {
        timerReset = timer;
    }

    private void Update()
    {
        timer -= Time.deltaTime;

        if (timer <= 0)
        {
            //prvi, duzi nacin
            int randomprefabs = Random.Range(0, characters.Length);
            int randomSpawnPOsition = Random.Range(0, spawnPositions.Length);
            Instantiate(characters[randomprefabs], spawnPositions[randomSpawnPOsition], spawnPositions[randomSpawnPOsition]);

            //drugi kraci nacin
            Instantiate(characters[Random.Range(0, characters.Length)], spawnPositions[Random.Range(0, spawnPositions.Length)].position, Quaternion.identity);

            timer = timerReset;
        }
    }
}
