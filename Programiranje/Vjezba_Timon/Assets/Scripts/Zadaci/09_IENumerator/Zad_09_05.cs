using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Zad_09_05 : MonoBehaviour
{
    public float maxHP = 100;
    float currentHP;

    public Text health;

    private void Start()
    {
        currentHP = maxHP;
        StartCoroutine(HealthRegen());
        StartCoroutine(PoisonDamage());
    }

    IEnumerator HealthRegen()
    {
        while (true)
        {
            currentHP += 5;
            HealthIspisIProvjera();
            yield return new WaitForSeconds(5);
        }
    }

    IEnumerator PoisonDamage()
    {
        while (true)
        {
            currentHP *= 0.95f;
            HealthIspisIProvjera();
            yield return new WaitForSeconds(10);
        }
    }

    void HealthIspisIProvjera()
    {
        if (currentHP <= 0)
            currentHP = 0; //ako je samo jedna naredba u if-u ne trebaju se pisati viticaste zagrade

        else if (currentHP >= maxHP)
            currentHP = maxHP;

        health.text = currentHP.ToString();
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "ekstrahealthregen")
        {
            currentHP += 5 * Time.deltaTime;
            HealthIspisIProvjera();
        }
    }
}
