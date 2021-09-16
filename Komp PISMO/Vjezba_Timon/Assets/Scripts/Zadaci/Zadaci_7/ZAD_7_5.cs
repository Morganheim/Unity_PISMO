using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZAD_7_5 : MonoBehaviour
{
    Rigidbody rb;
    public int speed;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();

    }
    private void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            rb.AddForce(Vector3.right * speed);
        }
        if (Input.GetKey(KeyCode.S))
        {
            rb.AddForce(Vector3.right * -speed);
        }
        if (Input.GetKey(KeyCode.A))
        {
            rb.AddForce(Vector3.forward * speed);
        }
        if (Input.GetKey(KeyCode.D))
        {
            rb.AddForce(Vector3.back * speed);
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.AddForce(Vector3.up * speed * 100);
        }
    }
}
