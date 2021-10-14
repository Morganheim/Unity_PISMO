using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zad_5_6 : MonoBehaviour
{
    public int x;

    private void Start()
    {
        for(int i = x; i <= 10; i++)
        {
            transform.localScale -= new Vector3(0, x, x);
        }
    }
}
