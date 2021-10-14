using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class col_Zad_1_6 : MonoBehaviour
{
    public float score = 0;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Cube")
        {
            score++;
        }
    }
}
