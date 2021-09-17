using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class col_Zad_1_7 : MonoBehaviour
{
    Rigidbody rb;
    public float hp;
    float score = 0;
    public float speed = 3.5f;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Sphere")
        {
            score++;
            //nestane sfera da ne mozemo vise puta pokupit score++
            other.gameObject.SetActive(false);
        }

        if (other.gameObject.tag == "Capsule")
        {
            hp -= 10;
            other.gameObject.SetActive(false);
        }
    }

    private void Update()
    {
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



        if (score >= 10)
        {
            Debug.Log("Pobijedio si!");
        }
        if (hp <= 0)
        {
            Debug.Log("Umro si!");
        }
    }
}
