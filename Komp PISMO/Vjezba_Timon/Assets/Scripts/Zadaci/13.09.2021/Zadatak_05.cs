using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zadatak_05 : MonoBehaviour
{
    public float xScale;
    public float yScale;
    public float zScale;

    private void Update()
    {
        transform.localScale += new Vector3(xScale, yScale, zScale) * Time.deltaTime;
    }
}
