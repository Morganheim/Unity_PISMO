using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DZ_2_home : MonoBehaviour
{
    public float x;
    public int y;

    float zbroj;

    private void Start()
    {
        zbroj = x + y;

        if (zbroj > 20)
        {
            transform.localScale += new Vector3(20, 20, 20);
        }
        else if (zbroj <= 20)
        {
            transform.localScale -= new Vector3(zbroj, zbroj, zbroj);
        }
    }
}
