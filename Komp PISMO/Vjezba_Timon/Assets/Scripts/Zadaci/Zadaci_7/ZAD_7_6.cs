using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZAD_7_6 : MonoBehaviour
{
    Rigidbody rb;

    private void Start()
    {
        rb.constraints = RigidbodyConstraints.FreezeRotation;
    }
}
