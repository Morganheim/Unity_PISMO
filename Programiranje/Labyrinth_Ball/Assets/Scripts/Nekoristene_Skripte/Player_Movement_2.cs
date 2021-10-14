using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Movement_2 : MonoBehaviour
{
    public float speed = 3;

    Rigidbody rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        rb.constraints = RigidbodyConstraints.FreezeRotation;

        if (Input.GetKey(KeyCode.W))
        {
            transform.position += Vector3.forward * -speed;
        }
        if (Input.GetKeyUp(KeyCode.W))
        {
            rb.constraints = RigidbodyConstraints.FreezePositionZ;
        }

        if (Input.GetKey(KeyCode.S))
        {
            transform.position += Vector3.forward * speed;
        }
        if (Input.GetKeyUp(KeyCode.S))
        {
            rb.constraints = RigidbodyConstraints.FreezePositionZ;
        }

        if (Input.GetKey(KeyCode.A))
        {
            transform.position += Vector3.right * speed;
        }
        if (Input.GetKeyUp(KeyCode.A))
        {
            rb.constraints = RigidbodyConstraints.FreezePositionX;
        }

        if (Input.GetKey(KeyCode.D))
        {
            transform.position += Vector3.right * -speed;
        }
        if (Input.GetKeyUp(KeyCode.D))
        {
            rb.constraints = RigidbodyConstraints.FreezePositionX;
        }
    }
}
