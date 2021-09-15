using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DZ_5_75_home : MonoBehaviour
{
    // 5) Unesite neku javnu vrijednost,
    // napravite for petlju u start metodi koja će služiti
    // da se u svakom ponavljanju kocka
    // poveća po x osi za vrijednost i
    // dok god je uvijet zadovoljen,
    // i < javna vrijednost 

    // 7) Odradite ekvivalentni kod iz zadataka 5 i 6 koristeći while petlju

    public int x;
    private int i = 0;

    private void Start()
    {
        while (i < x)
        {
            transform.localScale += Vector3.right * x;
            i++;
        }
    }
}
