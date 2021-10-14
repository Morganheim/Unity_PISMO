using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MV2_1b : MonoBehaviour
{
    float x = 6;
    float y = 7;
    float zbroj;
    float z;

    private void Awake()
    {
        zbroj = x + y;
        z = zbroj + y;
    }
}
