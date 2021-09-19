using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Movement_5 : MonoBehaviour
{
    Rigidbody rb;

    public float speed = 20;
    public float rotSpeed = 1;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        rb.constraints = RigidbodyConstraints.FreezeRotationX | RigidbodyConstraints.FreezeRotationZ;

        if (Input.GetKey(KeyCode.W))
        {
            rb.velocity = Vector3.forward * -speed;
        }
        if (Input.GetKeyUp(KeyCode.W))
        {
            rb.constraints = RigidbodyConstraints.FreezePositionZ;
        }

        if (Input.GetKey(KeyCode.S))
        {
            rb.velocity = Vector3.forward * speed;
        }
        if (Input.GetKeyUp(KeyCode.S))
        {
            rb.constraints = RigidbodyConstraints.FreezePositionZ;
        }

        if (Input.GetKey(KeyCode.A))
        {
            rb.velocity = Vector3.right * speed;
        }
        if (Input.GetKeyUp(KeyCode.A))
        {
            rb.constraints = RigidbodyConstraints.FreezePositionX;
        }

        if (Input.GetKey(KeyCode.D))
        {
            rb.velocity = Vector3.right * -speed;
        }
        if (Input.GetKeyUp(KeyCode.D))
        {
            rb.constraints = RigidbodyConstraints.FreezePositionX;
        }

        if (Input.GetKey(KeyCode.Q))
        {
            transform.eulerAngles += Vector3.up * -rotSpeed;
        }
        if (Input.GetKeyUp(KeyCode.Q))
        {
            rb.constraints = RigidbodyConstraints.FreezeRotation;
        }

        if (Input.GetKey(KeyCode.E))
        {
            transform.eulerAngles += Vector3.up * rotSpeed;
        }
        if (Input.GetKeyUp(KeyCode.E))
        {
            rb.constraints = RigidbodyConstraints.FreezeRotation;
        }
    }
}
