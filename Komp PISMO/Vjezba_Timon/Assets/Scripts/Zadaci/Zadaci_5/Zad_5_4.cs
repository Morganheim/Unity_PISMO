using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zad_5_4 : MonoBehaviour
{
    float scaleX;
    float scaleY;
    float scaleZ;

    private void Start()
    {
        scaleX = transform.localScale.x;
        scaleY = transform.localScale.y;
        scaleZ = transform.localScale.z;

        transform.localScale *= -1;
    }
}
