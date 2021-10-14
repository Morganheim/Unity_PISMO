using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GO_Zad_07 : MonoBehaviour
{
    public GameObject sfera1;
    public GameObject sfera2;

    public GameObject kapsula1;
    public GameObject kapsula2;
    public GameObject kapsula3;
    public GameObject kapsula4;

    Rigidbody rb;

    public float speed = 5;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        kapsula1.gameObject.SetActive(false);
        kapsula2.gameObject.SetActive(false);
        kapsula3.gameObject.SetActive(false);
        kapsula4.gameObject.SetActive(false);
    }



    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject == sfera1)
        {
            sfera1.gameObject.SetActive(false);
            kapsula1.gameObject.SetActive(true);
            kapsula2.gameObject.SetActive(true);
            kapsula3.gameObject.SetActive(true);
            kapsula4.gameObject.SetActive(true);
        }
        if (collision.gameObject == sfera2)
        {
            sfera2.gameObject.SetActive(false);
            kapsula1.gameObject.SetActive(true);
            kapsula2.gameObject.SetActive(true);
            kapsula3.gameObject.SetActive(true);
            kapsula4.gameObject.SetActive(true);
        }

        if(collision.gameObject==kapsula1 || collision.gameObject==kapsula2 || collision.gameObject == kapsula3 || collision.gameObject == kapsula4)
        {
            if (kapsula1.activeSelf)
            {
                kapsula1.gameObject.SetActive(false);
            }
            if (kapsula2.activeSelf)
            {
                kapsula2.gameObject.SetActive(false);
            }
            if (kapsula3.activeSelf)
            {
                kapsula3.gameObject.SetActive(false);
            }
            if (kapsula4.activeSelf)
            {
                kapsula4.gameObject.SetActive(false);
            }
        }
    }

    private void Update()
    {
        rb.constraints = RigidbodyConstraints.FreezeRotation | RigidbodyConstraints.FreezePositionX | RigidbodyConstraints.FreezePositionY;
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            rb.velocity = Vector3.back * speed;
        }
        //if (Input.GetKeyUp(KeyCode.LeftArrow))
        //{
        //    rb.constraints = RigidbodyConstraints.FreezePositionZ;
        //}

        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            rb.velocity = Vector3.forward * speed;
        }
        //if (Input.GetKeyUp(KeyCode.RightArrow))
        //{
        //    rb.constraints = RigidbodyConstraints.FreezePositionZ;
        //}




    }
}
