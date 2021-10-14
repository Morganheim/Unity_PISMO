using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MV2_1e : MonoBehaviour
{
    public float x = -3.6f;
    public float y = 10;
    public float umnozak;

    private void Start()
    {
        umnozak = x * y;

        if (umnozak > 100)
        {
            x += umnozak;
        }
        else if (umnozak < 100)
        {
            y += umnozak;
        }
        else if (umnozak == 100)
        {
            x += x;
            y += y;
        }
    }
}
