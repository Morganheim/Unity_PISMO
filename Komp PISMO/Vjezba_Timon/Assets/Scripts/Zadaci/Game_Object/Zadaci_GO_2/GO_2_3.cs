using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GO_2_3 : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Sfera")
        {
            Destroy(collision.gameObject);
        }
    }
}
