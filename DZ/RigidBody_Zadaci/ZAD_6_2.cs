using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZAD_6_2 : MonoBehaviour
{
    public Rigidbody rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (rb.useGravity == true)
            {
                rb.useGravity = false;
            }
            else if (rb.useGravity == false)
            {
                rb.useGravity = true;
            }
        }
    }
}
