using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DZ_2_05 : MonoBehaviour
{
    private bool ispisZ = true;
    private void Start()
    {
        transform.localScale += new Vector3(0, 0, 89);

        if (ispisZ)
        {
            Debug.Log("Iznos Z osi je " + transform.localScale.z + ".");
            ispisZ = false;
        }
    }

    private void Update()
    {
        transform.localScale += new Vector3(0, 0.25f, 0);
    }
}

