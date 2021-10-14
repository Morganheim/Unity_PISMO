using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DZ_1_home : MonoBehaviour
{
    public float x;
    public float y;

    private float zbroj;

    private void Start()
    {
        zbroj = x + y;
        transform.position += new Vector3(zbroj, zbroj, zbroj);
        transform.Rotate(new Vector3(zbroj, zbroj, zbroj));
        transform.localScale += new Vector3(zbroj, zbroj, zbroj);

        Debug.Log("zbroj je " + zbroj);
    }
}
