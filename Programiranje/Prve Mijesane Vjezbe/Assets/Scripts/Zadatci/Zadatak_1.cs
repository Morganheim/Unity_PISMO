using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zadatak_1 : MonoBehaviour
{
    public int prviBroj; //prvi javni cijeli broj
    public int drugiBroj; //drugi javni cijeli broj
    public int zbroj; //javna varijabla u koju ce se pohranjivati zbroj dvaju sijelih brojeva

    private void Start() //metoda Start, koja se odvija prije prvog framea
    {
        zbroj = prviBroj + drugiBroj; //definiranje varijable "zbroj" kao zbroja varijabli "prviBroj" i "drugiBroj"
        Debug.Log("Zbroj je " + zbroj + "."); //ispis varijable "zbroj" u konzoli
    }
}
