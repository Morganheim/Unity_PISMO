using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DZ_5_5_home : MonoBehaviour
{
    // 5) Unesite neku javnu vrijednost,
    // napravite for petlju u start metodi
    // koja će služiti da se u svakom ponavljanju
    // kocka poveća po x osi za vrijednost
    // i dok god je uvijet zadovoljen,
    // i < javna vrijednost

    public int x;

    private void Start()
    {
        for(int i=0; i < x; i++)
        {
            transform.localScale += Vector3.right * x;
        }
    }
}
