using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GO_Zad_04 : MonoBehaviour
{
    public GameObject sfera;
    public float speed = 5;
    Rigidbody rb;
    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        sfera.gameObject.SetActive(false);
    }

    
}
