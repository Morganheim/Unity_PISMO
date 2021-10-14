using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AS_Zas_09 : MonoBehaviour
{
    Rigidbody rb;

    public float speed = 3;

    public int score = 0;
    public float hp = 100;
    bool scoreLog = true;
    bool hpLog = true;

    public AudioClip coinSound;
    public AudioClip hpSound;

    public AudioSource ass;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        ass = GetComponent<AudioSource>();

    }


    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Sphere")
        {
            score++;
            other.gameObject.SetActive(false);
            ass.clip = coinSound;
            ass.Play();
        }
    }



    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Capsule")
        {
            hp -= 10;
            collision.gameObject.SetActive(false);
            ass.clip = hpSound;
            ass.Play();
        }
    }


    private void Update()
    {
        rb.constraints = RigidbodyConstraints.FreezeRotation;


        if (Input.GetKey(KeyCode.W))
        {
            rb.velocity = Vector3.forward * speed;
        }
        if (Input.GetKeyUp(KeyCode.W))
        {
            rb.constraints = RigidbodyConstraints.FreezePositionZ;
        }

        if (Input.GetKey(KeyCode.S))
        {
            rb.velocity = Vector3.forward * -speed;
        }
        if (Input.GetKeyUp(KeyCode.S))
        {
            rb.constraints = RigidbodyConstraints.FreezePositionZ;
        }

        if (Input.GetKey(KeyCode.D))
        {
            rb.velocity = Vector3.right * speed;
        }
        if (Input.GetKeyUp(KeyCode.D))
        {
            rb.constraints = RigidbodyConstraints.FreezePositionX;
        }

        if (Input.GetKey(KeyCode.A))
        {
            rb.velocity = Vector3.right * -speed;
        }
        if (Input.GetKeyUp(KeyCode.A))
        {
            rb.constraints = RigidbodyConstraints.FreezePositionX;
        }


        
        if (hp <= 0)
        {
            if (hpLog)
            {
                Debug.Log("Umro si.");
                hpLog = false;
            }
        }
        if (score >= 10)
        {
            if (scoreLog)
            {
                Debug.Log("Pobjedio si.");
                scoreLog = false;
            }
        }

    }
}
