using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zadatak_2 : MonoBehaviour
{
    public float x; //javna varijabla za prvi broj
    public float y; //javna varijabla za drugi broj
    float umnozak; //privatna varijabla za umnozak brojeva pohranjenih u varijable "x" i "y"

    private void Update() //metoda Update koja se odvija svaki frame
    {
        umnozak = x * y; //definiranje varijable "umnozak" kao umnoska varijabli "x" i "y"
        Debug.Log("Umnozak je " + umnozak + "."); //ispis vrijednosti varijable "umnozak" u konzoli
    }
}
