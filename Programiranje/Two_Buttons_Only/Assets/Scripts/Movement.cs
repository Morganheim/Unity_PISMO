using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    Rigidbody rb;
    public float speed;
    public float jumpspeed;
    bool Grounded;
    public float jumpStr;
    
  
    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
    private void Update()
    {
        if (Input.GetKey(KeyCode.D)&& Grounded == true)
        {
            rb.AddForce((Vector3.forward * 2) * speed);
            rb.velocity = Vector3.ClampMagnitude(rb.velocity, jumpspeed);
          
        }
        if (Input.GetKey(KeyCode.D) && Grounded == false)
        {
            rb.AddForce(new Vector3(0,0,0.2f));
        }

            if (Input.GetKeyDown(KeyCode.Space) && Grounded == true)
        {
            rb.velocity +=(new  Vector3(0, 2, 0) * jumpStr);
            
        }
        else if(Grounded == false)
        {
            Physics.gravity = new Vector3(0, -15.0F, 0);
        }
        
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Floor")
        {
            Grounded = true;
        }
    }
    private void OnCollisionExit(Collision collision)
    {
        if(collision.gameObject.tag == "Floor")
        {
            Grounded = false;
        }
    }
}
            
            
            
