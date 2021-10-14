using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Invoke_Ex2 : MonoBehaviour
{
    private void Start()
    {
        Invoke("StvoriKocku", 3f); //vrijeme oznacava nakon koliko da se pokrene metoda
    }

    void StvoriKocku()
    {
        GameObject kockica = GameObject.CreatePrimitive(PrimitiveType.Cube);
        kockica.transform.position = Vector3.zero;
    }
}
