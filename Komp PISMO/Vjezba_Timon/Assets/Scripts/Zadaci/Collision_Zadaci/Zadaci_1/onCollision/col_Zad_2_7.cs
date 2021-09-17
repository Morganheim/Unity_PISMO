using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class col_Zad_2_7 : MonoBehaviour
{
    Rigidbody rb;

    public float score = 0;
    public float speed = 3.5f;
    public float health = 100;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Sphere")
        {
            score++;
            collision.gameObject.SetActive(false);
        }

        if (collision.gameObject.tag == "Capsule")
        {
            health -= 10;
            collision.gameObject.SetActive(false);
        }
    }

    private void Update()
    {
        if (health <= 0)
        {
            rb.constraints = RigidbodyConstraints.FreezeAll;
            Debug.Log("Umro si, n00b!");
        }
        if (score >= 10)
        {
            rb.constraints = RigidbodyConstraints.FreezeAll;
            Debug.Log("Pobjedio si! Baš si gazda!");
        }

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
            rb.AddForce(Vector3.forward * -speed);
        }
        if (Input.GetKeyUp(KeyCode.D))
        {
            rb.constraints = RigidbodyConstraints.FreezePositionZ;
        }
    }
}
