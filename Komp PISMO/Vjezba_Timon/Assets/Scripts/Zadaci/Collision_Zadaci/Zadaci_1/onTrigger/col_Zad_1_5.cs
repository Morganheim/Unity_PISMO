using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class col_Zad_1_5 : MonoBehaviour
{
    public float health;
    public float healthRegen;
    public float dmg;
    float maxHealth = 500;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Heal")
        {
            health -= dmg / 2;
        }
        if (other.gameObject.tag == "Sphere")
        {
            health -= dmg;
        }
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "Heal")
        {
            health += healthRegen * Time.deltaTime;
        }
        if (other.gameObject.tag == "Sphere")
        {
            health -= dmg * Time.deltaTime;
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
