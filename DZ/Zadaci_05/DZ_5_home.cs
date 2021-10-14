using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DZ_5_home : MonoBehaviour
{
    public int int1;
    public int int2;
    public float float1;
    public float float2;

    private void Update()
    {
        if(int1 * int2 + float1 - float2 * int1 >= int1 * int2 * float1 / float2)
        {
            transform.localScale += Vector3.one * Time.deltaTime;
            transform.Rotate(Vector3.one * 2 * Time.deltaTime);
        }
        else
        {
            transform.localScale -= Vector3.one * 2 * Time.deltaTime;
            transform.Rotate(Vector3.one * Time.deltaTime);
        }
    }
}
