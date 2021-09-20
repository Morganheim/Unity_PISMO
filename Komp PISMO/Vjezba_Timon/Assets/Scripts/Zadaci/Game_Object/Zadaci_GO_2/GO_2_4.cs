using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GO_2_4 : MonoBehaviour
{
    public GameObject kocka;
    public GameObject sfera;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject == sfera)
        {
            Destroy(this);
        }
    }
}
