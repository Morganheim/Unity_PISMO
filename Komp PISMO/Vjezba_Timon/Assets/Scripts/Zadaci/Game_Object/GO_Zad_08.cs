using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GO_Zad_08 : MonoBehaviour
{
    public GameObject objekt;

    bool radiSkripta = true;

    public int brojilo = 0;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            radiSkripta = !radiSkripta;
        }
        if (radiSkripta)
        {
            PaliGasi();
        }
        if (brojilo >= 5)
        {
            Debug.Log("Bravo, streak ti je " + brojilo + ".");
        }

    }
    void PaliGasi()
    {
        //objekt.SetActive(!objekt.activeSelf);
        if (objekt.activeSelf == true)
        {
            objekt.SetActive(false);
            brojilo = 0;
        }
        else if (objekt.activeSelf == false)
        {
            objekt.SetActive(true);
            brojilo++;
        }
    }
}
