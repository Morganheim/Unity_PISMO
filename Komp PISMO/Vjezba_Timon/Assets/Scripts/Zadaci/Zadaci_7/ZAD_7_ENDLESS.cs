using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZAD_7_ENDLESS : MonoBehaviour
{
    Rigidbody rb;
    public float speed = 3.5f;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();

    }
    private void Update()
    {
        y = transform.position.y;
        if (Input.GetKey(KeyCode.W))
        {
            rb.constraints = RigidbodyConstraints.FreezeRotation;
            rb.AddForce(Vector3.right * speed);
        }
        if (Input.GetKeyUp(KeyCode.W))
        {
            rb.constraints = RigidbodyConstraints.FreezePositionX;
        }


        if (Input.GetKey(KeyCode.S))
        {
            rb.constraints = RigidbodyConstraints.FreezeRotation;
            rb.AddForce(Vector3.right * -speed);
        }
        if (Input.GetKeyUp(KeyCode.S))
        {
            rb.constraints = RigidbodyConstraints.FreezePositionX;
        }


        if (Input.GetKey(KeyCode.A))
        {
            rb.constraints = RigidbodyConstraints.FreezeRotation;
            rb.AddForce(Vector3.forward * speed);
        }
        if (Input.GetKeyUp(KeyCode.A))
        {
            rb.constraints = RigidbodyConstraints.FreezePositionZ;
        }


        if (Input.GetKey(KeyCode.D))
        {
            rb.constraints = RigidbodyConstraints.FreezeRotation;
            rb.AddForce(Vector3.back * speed);
        }
        if (Input.GetKeyUp(KeyCode.D))
        {
            rb.constraints = RigidbodyConstraints.FreezePositionZ;
        }


        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.constraints = RigidbodyConstraints.FreezeRotation;
            rb.AddForce(Vector3.up * speed * 100);
        }
    }
}
