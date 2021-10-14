using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zadatak_8 : MonoBehaviour
{
    public int intX;
    public float floatX;
    public bool boolX;
    public string stringX;

    private void Start()
    {
        Debug.Log("int = " + intX + ", float = " + floatX + ", bool = " + boolX + ", string = " + stringX);
    }
}
