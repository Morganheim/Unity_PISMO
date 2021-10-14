using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class co_Zad_1_3 : MonoBehaviour
{
    public float Health;

    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "Sphere")
        {
            Health -= 5 * Time.deltaTime;
        }
    }
}
