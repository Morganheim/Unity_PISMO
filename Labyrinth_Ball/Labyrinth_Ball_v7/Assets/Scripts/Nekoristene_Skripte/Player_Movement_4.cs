using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Movement_4 : MonoBehaviour
{
    Rigidbody rb;

    public float speed = 7;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            transform.position += Vector3.forward * -speed;
            rb.constraints = RigidbodyConstraints.FreezeRotationX | RigidbodyConstraints.FreezeRotationZ;
        }
        if (Input.GetKeyUp(KeyCode.W))
        {
            rb.constraints = RigidbodyConstraints.FreezePositionZ;
        }

        if (Input.GetKeyDown(KeyCode.S))
        {
            transform.position += Vector3.forward * speed;
            rb.constraints = RigidbodyConstraints.FreezeRotationX | RigidbodyConstraints.FreezeRotationZ;
        }
        if (Input.GetKeyUp(KeyCode.S))
        {
            rb.constraints = RigidbodyConstraints.FreezePositionZ;
        }

        if (Input.GetKeyDown(KeyCode.A))
        {
            transform.position += Vector3.right * speed;
            rb.constraints = RigidbodyConstraints.FreezeRotationX | RigidbodyConstraints.FreezeRotationZ;
        }
        if (Input.GetKeyUp(KeyCode.A))
        {
            rb.constraints = RigidbodyConstraints.FreezePositionX;
        }

        if (Input.GetKeyDown(KeyCode.D))
        {
            transform.position += Vector3.right * -speed;
            rb.constraints = RigidbodyConstraints.FreezeRotationX | RigidbodyConstraints.FreezeRotationZ;
        }
        if (Input.GetKeyUp(KeyCode.D))
        {
            rb.constraints = RigidbodyConstraints.FreezePositionX;
        }

        if (Input.GetKeyDown(KeyCode.Q))
        {
            transform.eulerAngles += Vector3.up * speed;
        }
        if (Input.GetKeyUp(KeyCode.Q))
        {
            rb.constraints = RigidbodyConstraints.FreezeRotationY;
        }

        if (Input.GetKeyDown(KeyCode.E))
        {
            transform.eulerAngles += Vector3.up * -speed;
        }
        if (Input.GetKeyUp(KeyCode.E))
        {
            rb.constraints = RigidbodyConstraints.FreezeRotationY;
        }
    }
}
