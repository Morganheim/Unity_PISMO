using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_1_rotacija : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        transform.Rotate(Vector3.forward * 90);
    }
}
