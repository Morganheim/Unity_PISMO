using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MV2_1a : MonoBehaviour
{
    float x = 17.2f;
    float y = 12.32f;
    public float javna;

    private void Start()
    {
        javna = x + y;
        Debug.Log(javna);
    }
}
