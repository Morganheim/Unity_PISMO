using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZAD_6_5 : MonoBehaviour
{
    Rigidbody rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.constraints = RigidbodyConstraints.FreezeRotationX | RigidbodyConstraints.FreezePositionX | RigidbodyConstraints.FreezePositionY;
    }
    private void Update()
    {
        if (Input.GetKey(KeyCode.U))
        {
            rb.constraints = RigidbodyConstraints.None;
        }
        if (Input.GetKey(KeyCode.F))
        {
            rb.constraints = RigidbodyConstraints.FreezePosition;
        }
    }
        
    
}
