using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zadatak_6 : MonoBehaviour
{
    float vrijednostX;

    private void Start()
    {
        vrijednostX = transform.localScale.x;
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            transform.localScale += Vector3.up * vrijednostX;
        }
    }
}
