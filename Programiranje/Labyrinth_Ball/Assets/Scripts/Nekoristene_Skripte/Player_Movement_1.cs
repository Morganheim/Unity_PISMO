using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Movement_1 : MonoBehaviour
{
    Rigidbody rb;

    public float speed = 25;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
    private void Update()
    {
        rb.constraints = RigidbodyConstraints.FreezeRotation;

        if (Input.GetKey(KeyCode.W))
        {
            rb.AddForce(Vector3.forward * -speed);
        }
        if (Input.GetKeyUp(KeyCode.W))
        {
            rb.constraints = RigidbodyConstraints.FreezePositionZ;
        }

        if (Input.GetKey(KeyCode.S))
        {
            rb.AddForce(Vector3.forward * speed);
        }
        if (Input.GetKeyUp(KeyCode.S))
        {
            rb.constraints = RigidbodyConstraints.FreezePositionZ;
        }

        if (Input.GetKey(KeyCode.A))
        {
            rb.AddForce(Vector3.right * speed);
        }
        if (Input.GetKeyUp(KeyCode.A))
        {
            rb.constraints = RigidbodyConstraints.FreezePositionX;
        }

        if (Input.GetKey(KeyCode.D))
        {
            rb.AddForce(Vector3.right * -speed);
        }
        if (Input.GetKeyUp(KeyCode.D))
        {
            rb.constraints = RigidbodyConstraints.FreezePositionX;
        }
    }
}
