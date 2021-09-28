using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LavaScript : MonoBehaviour
{
    public GameManager gm;
    public int scoreBrojac;
    public float timer;

    private void Start()
    {

        gm = FindObjectOfType<GameManager>();
    }

    private void Update()
    {
        transform.position += Vector3.up * (Time.deltaTime * 0.1f);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Platforma"|| collision.gameObject.tag == "Enemy")
        {
            Destroy(collision.gameObject);
        }
    }
}
