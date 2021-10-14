using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zad_5_5 : MonoBehaviour
{
    public float x;

    private void Start()
    {
        for (int i = 1; i < x; i++)
        {
            transform.localScale += Vector3.right * i;
        }
    }
}
