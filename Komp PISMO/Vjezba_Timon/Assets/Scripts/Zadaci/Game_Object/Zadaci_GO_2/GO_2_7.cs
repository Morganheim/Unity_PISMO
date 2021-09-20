using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GO_2_7 : MonoBehaviour
{
    public GameObject kocka;

    private void Start()
    {
        Instantiate(kocka, Vector3.zero, new Quaternion());
    }
}
