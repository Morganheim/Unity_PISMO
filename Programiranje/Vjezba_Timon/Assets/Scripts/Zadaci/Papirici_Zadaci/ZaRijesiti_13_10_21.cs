using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZaRijesiti_13_10_21 : MonoBehaviour
{
    public float speed;

    public bool xOs;
    public bool yOs;
    public bool zOs;

    public bool naprijed = true;

    private void Update()
    {
        if (yOs)
        {
            if (naprijed)
            {
                transform.Rotate(Vector3.up * speed);
            }
            else
            {
                transform.Rotate(Vector3.down * speed);
            }
        }

        if (xOs)
        {
            if (naprijed)
            {
                transform.Rotate(Vector3.right * speed);
            }
            else
            {
                transform.Rotate(Vector3.left * speed);
            }
        }

        if (zOs)
        {
            if (naprijed)
            {
                transform.Rotate(Vector3.forward * speed);
            }
            else
            {
                transform.Rotate(Vector3.back * speed);
            }
        }
    }
}
