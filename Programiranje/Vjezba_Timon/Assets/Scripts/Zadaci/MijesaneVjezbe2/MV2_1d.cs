using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MV2_1d : MonoBehaviour
{
    public int x = 8;
    public int y = 13;

    public int zbroj;

    private void Start()
    {
        zbroj = x + y;
        if (zbroj < 50)
        {
            x += x;
        }
        else if (zbroj >= 50)
        {
            y += y;
        }
    }
}
