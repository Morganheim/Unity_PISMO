using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zadatak_10 : MonoBehaviour
{
    public string ime;
    public string prezime;

    public int startnaVrijednost = 15;

    private void Start()
    {
        while (startnaVrijednost > 0)
        {
            Debug.Log("Ja sam " + ime + " " + prezime + ".");
            startnaVrijednost--;
        }
    }
}
