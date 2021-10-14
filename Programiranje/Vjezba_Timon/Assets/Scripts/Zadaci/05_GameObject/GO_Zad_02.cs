using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GO_Zad_02 : MonoBehaviour
{
    public GameObject predmet;

    private void Update()
    {
        if (predmet.activeSelf == true)
        {
            predmet.SetActive(false);
        }
        else if (predmet.activeSelf == false)
        {
            predmet.SetActive(true);
        }
    }
}
