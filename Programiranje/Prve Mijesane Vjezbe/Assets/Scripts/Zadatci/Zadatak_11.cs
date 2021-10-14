using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zadatak_11 : MonoBehaviour
{
    public int x;
    public int y;
    public int zbroj;

    private void Awake()
    {
        x = Random.Range(0, 34);
        y = Random.Range(0, 34);
    }

    private void Start()
    {
        zbroj = x + y;
        Debug.Log("Zbroj je " + zbroj);
    }
}
