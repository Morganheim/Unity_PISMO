using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Zad_10_03 : MonoBehaviour
{
    public Text bravoText;

    private void Start()
    {
        Invoke("Bravissimo", 10f);
    }

    void Bravissimo()
    {
        bravoText.text = "Bravo!";
    }
}
