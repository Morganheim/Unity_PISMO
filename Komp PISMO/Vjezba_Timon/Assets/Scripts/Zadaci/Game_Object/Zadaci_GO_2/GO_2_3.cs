using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GO_2_3 : MonoBehaviour
{
    public GameObject sfera;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Sfera")
        {
            Destroy(collision.gameObject);
        }
    }
}
