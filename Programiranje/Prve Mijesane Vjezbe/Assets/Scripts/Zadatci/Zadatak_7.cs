using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class Zadatak_7 : MonoBehaviour
{
    bool kolizija = false;
    public float speed;

    Rigidbody rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.useGravity = false;
    }

    private void Update()
    {
        if (!kolizija)
        {
            rb.velocity = Vector3.forward * speed;
        }
        else
        {
            rb.velocity = Vector3.back * speed;
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        kolizija = !kolizija;
    }
}
