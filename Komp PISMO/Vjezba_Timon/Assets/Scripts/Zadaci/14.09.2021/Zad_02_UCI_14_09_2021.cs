using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zad_02_UCI_14_09_2021 : MonoBehaviour
{
    public float scaleX;
    public float scaleY;
    public float scaleZ;

    public bool grow;

    private void Update()
    {
        if (grow)
        {
            transform.localScale += new Vector3(scaleX, scaleY, scaleZ);
        }
        else
        {
            transform.localScale -= new Vector3(scaleX, scaleY, scaleZ);
        }
    }
}
