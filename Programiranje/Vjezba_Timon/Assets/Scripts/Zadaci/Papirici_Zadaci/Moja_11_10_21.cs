using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class Moja_11_10_21 : MonoBehaviour
{
    Rigidbody rb;

    bool grounded;
    public float speed;
    public float jumpSpeed;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();

        speed = 7.5f;
    }

    private void OnCollisionStay(Collision collision)
    {
        if (collision.gameObject.tag == "Floor")
        {
            grounded = true;
        }
    }

    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.tag == "Floor")
        {
            grounded = false;
        }
    }

    private void Update()
    {
        if (Input.GetKey(KeyCode.D) || Input.GetKeyDown(KeyCode.RightArrow))
        {
            rb.velocity = Vector3.right * speed;
        }
        if (Input.GetKeyUp(KeyCode.D) || Input.GetKeyUp(KeyCode.RightArrow))
        {
            rb.constraints = RigidbodyConstraints.FreezePosition;
        }

        if (Input.GetKey(KeyCode.A) || Input.GetKeyDown(KeyCode.LeftArrow))
        {
            rb.velocity = Vector3.right * speed;
        }
        if (Input.GetKeyUp(KeyCode.A) || Input.GetKeyUp(KeyCode.LeftArrow))
        {
            rb.constraints = RigidbodyConstraints.FreezePosition;
        }

        if (grounded)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                rb.AddForce(Vector3.up * jumpSpeed);
            }
        }
    }
}
