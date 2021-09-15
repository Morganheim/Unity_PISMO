using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DZ_5_6_home : MonoBehaviour
{
    // 6) Unesite neku javnu vrijednost,
    // napravite for petlju u start metodi
    // koja će služiti da se u svakom ponavljanju
    // kocka smanji po y i z osi
    // za javnu vrijednost
    // dok god je uvijet zadovoljen,
    // uvijet je i <= 10

    public int x;

    private void Start()
    {
        for(int i = 0; i <= 10; i++)
        {
            transform.localScale -= new Vector3(0, x, x);
        }
    }
}
