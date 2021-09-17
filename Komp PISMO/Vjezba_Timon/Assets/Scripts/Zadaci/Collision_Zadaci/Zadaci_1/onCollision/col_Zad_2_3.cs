using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class col_Zad_2_3 : MonoBehaviour
{
    public float health;

    private void OnCollisionStay(Collision collision)
    {
        if (collision.gameObject.tag == "Sphere")
        {
            health -= 5 * Time.deltaTime;
        }
    }
}
