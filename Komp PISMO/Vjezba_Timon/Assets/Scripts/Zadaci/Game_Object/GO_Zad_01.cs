using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GO_Zad_01 : MonoBehaviour
{
    public GameObject predmet;

    private void Start()
    {
        //NE
        //predmet = GetComponent<GameObject>();
        //predmet = gameObject;
        predmet = this.gameObject;
        predmet.SetActive(false);
        this.gameObject.SetActive(false);
    }
}
