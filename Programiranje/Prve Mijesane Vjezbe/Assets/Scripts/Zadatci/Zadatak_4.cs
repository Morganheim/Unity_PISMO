using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zadatak_4 : MonoBehaviour
{
    public float xOs;
    public float yOs;
    public float zOs;

    private void Start()
    {
        transform.localScale = new Vector3(xOs, yOs, zOs);
        transform.localScale += new Vector3(5, 0, 5);
    }
}
