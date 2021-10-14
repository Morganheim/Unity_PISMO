using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GO_Zad_05 : MonoBehaviour
{
    public GameObject predmet1;
    public GameObject predmet2;
    public GameObject predmet3;
    public GameObject predmet4;
    public GameObject predmet5;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.I))
        {
            predmet1.SetActive(!predmet1.activeSelf);
            predmet2.SetActive(!predmet2.activeSelf);
            predmet3.SetActive(!predmet3.activeSelf);
            predmet4.SetActive(!predmet4.activeSelf);
            predmet5.SetActive(!predmet5.activeSelf);




            //if (predmet1.activeSelf)
            //{
            //    predmet1.gameObject.SetActive(false);
            //}
            //else if (!predmet1.activeSelf)
            //{
            //    predmet1.gameObject.SetActive(true);
            //}
            //if (predmet2.activeSelf)
            //{
            //    predmet2.gameObject.SetActive(false);
            //}
            //else if (!predmet2.activeSelf)
            //{
            //    predmet2.gameObject.SetActive(true);
            //}
            //if (predmet3.activeSelf)
            //{
            //    predmet3.gameObject.SetActive(false);
            //}
            //else if (!predmet3.activeSelf)
            //{
            //    predmet3.gameObject.SetActive(true);
            //}
            //if (predmet4.activeSelf)
            //{
            //    predmet4.gameObject.SetActive(false);
            //}
            //else if (!predmet4.activeSelf)
            //{
            //    predmet4.gameObject.SetActive(true);
            //}
            //if (predmet5.activeSelf)
            //{
            //    predmet5.gameObject.SetActive(false);
            //}
            //else if (!predmet5.activeSelf)
            //{
            //    predmet5.gameObject.SetActive(true);
            //}
        }



        if (Input.GetKeyDown(KeyCode.K))
        {
            predmet1.SetActive(!predmet1.activeSelf);


            //if (predmet1.activeSelf)
            //{
            //    predmet1.gameObject.SetActive(false);
            //}
            //else if (!predmet1.activeSelf)
            //{
            //    predmet1.gameObject.SetActive(true);
            //}
        }
    }
}
