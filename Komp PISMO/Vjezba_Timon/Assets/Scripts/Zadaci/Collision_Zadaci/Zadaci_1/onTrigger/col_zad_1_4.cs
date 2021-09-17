using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class col_zad_1_4 : MonoBehaviour
{
    public float health;
    public float healthRegen;
    bool gotOut;
    float maxHealth = 500;

    private void OnTriggerEnter(Collider other)
    {
        gotOut = false;
        if (other.gameObject.tag == "Sphere")
        {
            health -= 10;
        }
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "Sphere")
        {
            health -= 10 * Time.deltaTime;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        gotOut = true;
    }

    private void Update()
    {
        if (gotOut)
        {
            health += healthRegen * Time.deltaTime;
        }
        if (health >= maxHealth)
        {
            health = maxHealth;
        }
    }
}
