using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZAD_7_3 : MonoBehaviour
{
    Rigidbody rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();

    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.K))
        {
            if (rb.isKinematic)
            {
                rb.isKinematic = false;
            }
            else if (!rb.isKinematic)
            {
                rb.isKinematic = true;
            }
        }

        if (Input.GetKeyDown(KeyCode.G))
        {
            rb.useGravity = !rb.useGravity;
        }
    }
}
