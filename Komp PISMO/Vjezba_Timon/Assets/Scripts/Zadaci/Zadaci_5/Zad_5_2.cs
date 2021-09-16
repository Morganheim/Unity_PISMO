using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zad_5_2 : MonoBehaviour
{
    //2)
    //a
    int i;
    string c;
    float d;

    private void Start()
    {
        i = 1;
        c = "ivan";
        d = 55.5f;
        //d
        Debug.Log(i * 3);
        //e
        Debug.Log(c + "2");
        //f
        Debug.Log(d + c);
        //g
        //Debug.Log("2" * d);
        //h
        //Debug.Log(i * "2");
    }
}
