using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GO_2_6 : MonoBehaviour
{
    public GameObject objekt;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.M))
        {
            Destroy(objekt);
        }
    }
}
