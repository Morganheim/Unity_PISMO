using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GO_2_11 : MonoBehaviour
{
    Rigidbody rb;

    public int score;
    public float hp = 100;
    public float speed = 3.5f;

    public GameObject cylinder;

    public AudioClip scoreUpSound;
    public AudioClip hpLossSound;
    public AudioClip soundtrack;
    public AudioSource ass;
    public AudioSource backgroundMusic;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        ass = GetComponent<AudioSource>();
        backgroundMusic = GetComponent<AudioSource>();

        backgroundMusic.clip = soundtrack;
        backgroundMusic.Play();
        backgroundMusic.loop = true;
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Sphere")
        {
            score++;
            ass.clip = scoreUpSound;
            ass.Play();
            collision.gameObject.SetActive(false);
        }

        if (collision.gameObject.tag == "Capsule")
        {
            hp -= 10;
            ass.clip = hpLossSound;
            ass.Play();
            Destroy(collision.gameObject);
            cylinder.SetActive(true);
        }

        if (collision.gameObject.name == "Cylinder")
        {
            hp += 10;
            collision.gameObject.SetActive(false);
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
            Debug.Log("Umro si.");
        }

        if (score == 10)
        {
            Debug.Log("Pobjedio si!");
            Destroy(this.gameObject);
        }

    }
}
