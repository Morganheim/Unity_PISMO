using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Solar_System : MonoBehaviour
{
    float sunSize = 696.340f * 2; //u tisucama kilometara, prva vrijednost je polumjer, zato je *2
    float mercurySize = 2.4397f * 2;
    float venusSize = 6.0518f * 2;
    float earthSize = 6.371f * 2;
    float marsSize = 3.3895f * 2;
    float jupiterSize = 69.911f * 2;
    float saturnSize = 58.232f * 2;
    float uranusSize = 25.362f * 2;
    float neptuneSize = 24.622f * 2;
    float moonSize = 1737.4f * 2;

    float sunRotSpeed;
    
    float AstroUnit = 150; //u milijonima kilometara

    float mercuryAU;
    float venusAU;
    float earthAU;
    float marsAU;
    float jupiterAU;
    float saturnAU;
    float uranusAU;
    float neptuneAU;
    float moonAU;

    public bool sun;
    public bool mercury;
    public bool venus;
    public bool earth;
    public bool mars;
    public bool jupiter;
    public bool saturn;
    public bool uranus;
    public bool neptune;
    public bool moon;


    private void Start()
    {
        mercuryAU = 0.4f * AstroUnit;
        venusAU = 0.33f + mercuryAU;
        earthAU = AstroUnit;
        marsAU = 1.5f * AstroUnit;
        jupiterAU = 5.2f * AstroUnit;
        saturnAU = 4.3f + jupiterAU;
        uranusAU = 19.8f * AstroUnit;
        neptuneAU = 10.5f * AstroUnit;
        moonAU = 0.002569f * AstroUnit;

        if (sun)
        {
            transform.position = Vector3.zero;
            transform.Rotate(new Vector3(0, sunRotSpeed, 0));
            transform.localScale = Vector3.one * sunSize;
        }
        if (mercury)
        {

            transform.localPosition = new Vector3(mercuryAU, 0, 0);

            transform.localScale = Vector3.one * mercurySize;
        }
        if (venus)
        {

            transform.localPosition = new Vector3(venusAU, 0, 0);

            transform.localScale = Vector3.one * venusSize;
        }
        if (earth)
        {

            transform.localPosition = new Vector3(earthAU, 0, 0);

            transform.localScale = Vector3.one * earthSize;
        }
        if (mars)
        {

            transform.localPosition = new Vector3(marsAU, 0, 0);

            transform.localScale = Vector3.one * marsSize;
        }
        if (jupiter)
        {

            transform.localPosition = new Vector3(jupiterAU, 0, 0);

            transform.localScale = Vector3.one * jupiterSize;
        }
        if (saturn)
        {

            transform.localPosition = new Vector3(saturnAU, 0, 0);

            transform.localScale = Vector3.one * saturnSize;
        }
        if (uranus)
        {

            transform.localPosition = new Vector3(uranusAU, 0, 0);

            transform.localScale = Vector3.one * uranusSize;
        }
        if (neptune)
        {

            transform.localPosition = new Vector3(neptuneAU, 0, 0);

            transform.localScale = Vector3.one * neptuneSize;
        }
        if (moon)
        {
            transform.localPosition = new Vector3(moonAU, 0, 0);

            transform.localScale = Vector3.one * moonSize;

        }
    }

    private void Update()
    {
        
    }
}
