using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class col_Zad_2_6 : MonoBehaviour
{
    public float score;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Cube")
        {
            score++;
        }
    }
}
