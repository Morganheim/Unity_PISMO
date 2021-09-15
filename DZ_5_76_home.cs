using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DZ_5_76_home : MonoBehaviour
{
    // 6) Unesite neku javnu vrijednost,
    // napravite for petlju u start metodi
    // koja će služiti da se u svakom ponavljanju kocka
    // smanji po y i z osi za javnu vrijednost
    // dok god je uvijet zadovoljen,
    // uvijet je i <= 10

    // 7) Odradite ekvivalentni kod iz zadataka 5 i 6 koristeći while petlju

    public int x;
    private int i = 0;

    private void Start()
    {
        while (i <= 10)
        {
            transform.localScale -= new Vector3(0, x, x);
            i++;
        }
    }
}
