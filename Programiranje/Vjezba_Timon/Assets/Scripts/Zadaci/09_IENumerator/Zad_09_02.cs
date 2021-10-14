using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zad_09_02 : MonoBehaviour
{
    public GameObject[] prefabs;

    private void Start()
    {
        StartCoroutine(PrefabGenerator());
    }

    IEnumerator PrefabGenerator()
    {
        while (true)
        {
            Instantiate(prefabs[Random.Range(0, prefabs.Length)], new Vector3(Random.Range(0, 10), Random.Range(0, 20), Random.Range(-15, 15)), Quaternion.identity);
            yield return new WaitForSeconds(5);
        }
    }
}
