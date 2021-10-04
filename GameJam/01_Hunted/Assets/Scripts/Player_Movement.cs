using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Movement : MonoBehaviour
{
    public GameManager gm;

    public float speed;
    bool grounded;

    Rigidbody rb;

    private void Start()
    {
        gm = FindObjectOfType<GameManager>();
        rb = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
        {
            rb.AddForce(Vector3.right * speed);
        }

        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
        {
            rb.AddForce(Vector3.left * speed);
        }

        if (Input.GetKey(KeyCode.Space)&&grounded)
        {
            rb.velocity = Vector3.up * speed * 3;

        }

        if (Input.GetKeyUp(KeyCode.Space))
        {
            rb.velocity = Vector3.down * speed;

        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Floor")
        {
            gm.life = 0;
            gm.DeathGame();

        }
        if (collision.gameObject.tag == "Platforma")
        {
            grounded = true;
        }
        if (collision.gameObject.tag == "Enemy")
        {
            gm.LoseLife();
            Debug.Log("aaa");
            gm.score--;
        }
    }

    private void OnCollisionStay(Collision collision)
    {
        if (collision.gameObject.tag == "Platforma")
        {
            grounded = true;
        }
    }

    private void OnCollisionExit(Collision collision)
    {
        grounded = false;
    }
}
