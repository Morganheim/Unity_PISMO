using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public int pickedArtefacts;
    public GameObject[] artefacts;
    public UIManager uiM;

    private void Start()
    {
        uiM = FindObjectOfType<UIManager>();
        artefacts = GameObject.FindGameObjectsWithTag("Artefact");
        //zelim da mi ispise koliko od koliko artefakata ima, - to treba napraviti UI Manager
        uiM.UpdateText(pickedArtefacts, artefacts.Length);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Artefact")
        {
            pickedArtefacts++;
            uiM.UpdateText(pickedArtefacts, artefacts.Length);
            other.gameObject.SetActive(false);
        }
    }
}
