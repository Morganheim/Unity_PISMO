using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Light))]
public class Zadatak_12 : MonoBehaviour
{
    Light lgh;

    private void Start()
    {
        lgh = GetComponent<Light>();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            lgh.enabled = !lgh.enabled;
        }
    }
}
