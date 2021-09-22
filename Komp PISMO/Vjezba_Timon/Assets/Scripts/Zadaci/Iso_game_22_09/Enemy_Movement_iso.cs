using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_Movement_iso : MonoBehaviour
{
    public GameManager_iso gm;
    public GameObject target;

    Rigidbody rb;

    public float speed;

    public bool isCapsule;

    private void Start()
    {
        gm = FindObjectOfType<GameManager_iso>();
        target = GameObject.FindGameObjectWithTag("Player");
        rb = GetComponent<Rigidbody>();

        if (isCapsule)
        {
            speed = 0.03f;
        }
        else if (!isCapsule)
        {
            speed = 0.01f;
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Wall")
        {
            gm.DodajScore();
            Destroy(this.gameObject);
        }

        if (collision.gameObject.tag == "Player")
        {
            gm.MakniLife();
            Destroy(this.gameObject);
        }
    }

    private void Update()
    {
        transform.LookAt(target.transform);
        transform.position = Vector3.MoveTowards(transform.position, target.transform.position, speed);

        if (gm.life <= 0)
        {
            Destroy(this.gameObject);
        }
    }
}
