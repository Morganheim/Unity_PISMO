using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zad_5_7 : MonoBehaviour
{
    public int x5;
    int i5 = 1;
    public int x6;
    int i6;

    private void Start()
    {
        //5
        while (i5 < x5)
        {
            transform.localScale += Vector3.right * i5;
            i5++;
        }

        //6
        i6 = x6;
        while (i6 < 10)
        {
            transform.localScale -= new Vector3(0, x6, x6);
            i6++;
        }
    }
}
