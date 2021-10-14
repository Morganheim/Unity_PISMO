using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZAD_7_2 : MonoBehaviour
{
    public float mass;
    Rigidbody rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.mass = mass;
    }
}
