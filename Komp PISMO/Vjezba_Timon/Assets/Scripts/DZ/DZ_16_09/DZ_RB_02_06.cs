using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DZ_RB_02_06 : MonoBehaviour
{
    Rigidbody rb;
    public bool kaboom;
    public float radius;
    public float exploPower;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        Vector3 explosionPos = transform.position;
        
    }
    private void Update()
    {
        if (kaboom)
        {
            rb.AddExplosionForce(exploPower, Vector3.one, radius);
        }
    }
}
