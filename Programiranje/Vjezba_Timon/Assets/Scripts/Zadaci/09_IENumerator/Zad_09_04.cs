using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Zad_09_04 : MonoBehaviour
{
    string ulovljen = "Nisi uspio pobjeci!";
    public Text ulovljenText;

    private void OnTriggerEnter(Collider other)
    {
        StartCoroutine(Ulov());
    }

    IEnumerator Ulov()
    {
        yield return new WaitForSeconds(5);
        ulovljenText.text = ulovljen;
    }
}
