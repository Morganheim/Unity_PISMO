using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZaRijesitiRigi_11_10_21 : MonoBehaviour
{
    Rigidbody rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.useGravity = false;
        rb.isKinematic = true;
        rb.constraints = RigidbodyConstraints.FreezeRotation;
    }
}
