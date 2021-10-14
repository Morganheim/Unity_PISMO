using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zadatak_1 : MonoBehaviour
{
    public int prviBroj;
    public int drugiBroj;
    public int zbroj;

    private void Start()
    {
        zbroj = prviBroj + drugiBroj;
        Debug.Log("Zbroj je " + zbroj + ".");
    }
}
