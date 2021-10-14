using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Zad_10_04 : MonoBehaviour
{
    string ulovljen = "Nisi uspio pobjeci!";

    public Text ulovljenText;

    private void OnTriggerEnter(Collider other)
    {
        Invoke("Ulov", 5f);
    }

    void Ulov()
    {
        ulovljenText.text = ulovljen.ToString();
    }
}
