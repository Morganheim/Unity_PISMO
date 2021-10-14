using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MV2_1f : MonoBehaviour
{
    public float javniBroj;

    private void Start()
    {
        if (javniBroj < 10)
        {
            javniBroj += 20;
        }
        else if (javniBroj > 10)
        {
            javniBroj -= 9;
        }
    }
}
