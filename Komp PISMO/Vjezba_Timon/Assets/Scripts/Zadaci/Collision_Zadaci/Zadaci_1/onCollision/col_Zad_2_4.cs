using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class col_Zad_2_4 : MonoBehaviour
{
    public float health;
    public float healthRegen;
    bool dirkanje;
    float maxHealth = 500;

    private void OnCollisionEnter(Collision collision)
    {
        dirkanje = true;
        if (collision.gameObject.tag == "Sphere")
        {
            health -= 10;
        }
    }

    private void OnCollisionStay(Collision collision)
    {
        if (collision.gameObject.tag == "Sphere")
        {
            health -= 10 * Time.deltaTime;
        }
    }

    private void OnCollisionExit(Collision collision)
    {
        dirkanje = false;
    }

    private void Update()
    {
        if (dirkanje)
        {
            health = healthRegen * Time.deltaTime;
        }
        if (health >= maxHealth)
        {
            health = maxHealth;
        }
    }
}
