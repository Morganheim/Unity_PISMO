using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ARR_01_03 : MonoBehaviour
{
    public string[] stringovi;

    private void Start()
    {
        for (int i = 0; i < stringovi.Length; i++)
        {
            Debug.Log("Ime je " + stringovi[i]);
        }
    }
}
