using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zadatak_10 : MonoBehaviour
{
    //javne varijable za scale
    public float xScale;
    public float yScale;
    public float zScale;

    //javne varijable za rotaciju
    public float xRot;
    public float yRot;
    public float zRot;

    //provjera da li smanjujemo ili povecavamo
    bool expand = true;

    //u startu provjeravamo je li nas objekt kocka ili kvadar
    private void Start()
    {
        if (transform.localScale.x != transform.localScale.y && transform.localScale.x != transform.localScale.z)
        {
            //Ako ih pretvorimo da su sve x
            var velicina = transform.localScale.x;
            transform.localScale = new Vector3(velicina, velicina, velicina);
            //ako ih pretvorimo u prosjek
            var prosjekVelicine = (transform.localScale.x + transform.localScale.y + transform.localScale.z) / 3;
            transform.localScale = new Vector3(prosjekVelicine, prosjekVelicine, prosjekVelicine);
        }
    }

    private void Update()
    {
        //ako je manji od 0.1 pa se treba povecavati
        if (transform.localScale.x <= 0.1f || transform.localScale.y <= 0.1f || transform.localScale.z <= 0.1f)
        {
            expand = true;
        }
        //ako je veci od 10 pa se treba smanjivati
        else if (transform.localScale.x >= 10f || transform.localScale.y >= 10f || transform.localScale.z >= 10f)
        {
            expand = false;
        }

        if (expand)
        {
            transform.localScale += new Vector3(xScale, yScale, zScale);
        }
        else
        {
            transform.localScale -= new Vector3(xScale, yScale, zScale);
        }
    }
}
