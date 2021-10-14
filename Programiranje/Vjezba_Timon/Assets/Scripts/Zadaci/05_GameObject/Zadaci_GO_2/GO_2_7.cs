using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GO_2_7 : MonoBehaviour
{
    public GameObject prefab;

    private void Start()
    {
        Instantiate(prefab, Vector3.zero, Quaternion.identity);
    }
}
