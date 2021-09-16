using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZAD_7_4 : MonoBehaviour
{
    Rigidbody rb;

    private void Awake()
    {
        rb.useGravity = true;
    }
    private void Start()
    {
        var gravity = GetComponent<Rigidbody>().useGravity = false;

        //var grav = GetComponent<Rigidbody>().useGravity;
        //grav = false;
        //grav = GetComponent<Rigidbody>().useGravity = grav;
    }
}
