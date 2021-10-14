using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class col_Zad_2_1 : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Sphere")
        {
            Debug.Log("Dotakli se.");
        }
    }

    private void OnCollisionStay(Collision collision)
    {
        if (collision.gameObject.tag == "Sphere")
        {
            Debug.Log("Dirkaju se. <3");
        }
    }

    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.tag == "Sphere")
        {
            Debug.Log("Više se ne dirkaju. </3");
        }
    }
}
