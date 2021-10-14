using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Rigidbody))]
public class Zad_10_05 : MonoBehaviour
{
    Rigidbody rb;

    public Text healthText;

    public float maxHP = 500;
    public float currentHP;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        currentHP = maxHP * 0.25f;
        InvokeRepeating("HpRegen", 5f, 5f);
        InvokeRepeating("PoisonDamage", 10f, 10f);
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "ekstrahealthregen")
        {
            currentHP += 5 * Time.deltaTime;
        }
    }

    void HpRegen()
    {
        currentHP += 5;
        HpProvjeraIspis();
    }

    void PoisonDamage()
    {
        currentHP *= 0.95f;
        HpProvjeraIspis();
    }

    void HpProvjeraIspis()
    {
        if (currentHP <= 0)
        {
            currentHP = 0;
        }
        if (currentHP >= maxHP)
        {
            currentHP = maxHP;
        }

        healthText.text = ((int)currentHP).ToString();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.S))
        {
            rb.velocity = Vector3.down * 5;
        }
        if (Input.GetKeyDown(KeyCode.W))
        {
            rb.velocity = Vector3.up * 5;
        }
    }
}
