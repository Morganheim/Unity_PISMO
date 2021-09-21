using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public Rigidbody rb;
    public float speed;

    public GameManager gm;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        gm = FindObjectOfType<GameManager>();
    }

    private void Update()
    {
        //Kretanje desno
        if (Input.GetKey(KeyCode.D)||Input.GetKey(KeyCode.RightArrow))
        {
            //transform.position += Vector3.right * speed;
            rb.AddForce(Vector3.right * speed);
        }

        //Kretanje lijevo
        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
        {
            //transform.position += Vector3.left * speed;
            rb.AddForce(Vector3.left * speed);
        }

        if (gm.life <= 0)
        {
            Destroy(this.gameObject);
        }
    }
}
