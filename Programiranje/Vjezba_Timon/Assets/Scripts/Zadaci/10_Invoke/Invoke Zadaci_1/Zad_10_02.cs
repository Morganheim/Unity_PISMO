using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zad_10_02 : MonoBehaviour
{
    public GameObject[] prefabs;

    private void Start()
    {
        InvokeRepeating("PrefabsSpawner", 5f, 5f);
    }

    void PrefabsSpawner()
    {
        Instantiate(prefabs[Random.Range(0, prefabs.Length)], new Vector3(Random.Range(-10f, 10f), Random.Range(-11.3f, 20f), Random.Range(-15.1f, 15.1f)), Quaternion.identity);
    }
}
