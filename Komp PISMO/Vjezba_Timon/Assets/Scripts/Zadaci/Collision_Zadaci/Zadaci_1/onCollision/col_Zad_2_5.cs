using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class col_Zad_2_5 : MonoBehaviour
{
    public float health;
    public float healthRegen;
    public float dmg;
    float maxHealth = 500;


    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Sphere")
        {
            health -= dmg;
        }

        if (collision.gameObject.tag == "Heal")
        {
            health -= dmg / 2;
        }
    }

    private void OnCollisionStay(Collision collision)
    {
        if (collision.gameObject.tag == "Sphere")
        {
            health -= dmg * Time.deltaTime;
        }

        if (collision.gameObject.tag == "Heal")
        {
            health += healthRegen * Time.deltaTime;
        }
    }

    private void Update()
    {
        if (health >= maxHealth)
        {
            health = maxHealth;
        }
    }
}
