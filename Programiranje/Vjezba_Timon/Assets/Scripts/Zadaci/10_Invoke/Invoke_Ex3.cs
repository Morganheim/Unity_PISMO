using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Invoke_Ex3 : MonoBehaviour
{
    public int counter;

    private void Start()
    {
        InvokeRepeating("SpawnPrimitiveObject", 2f, 0.5f); //prvi broj je koliko se ceka prije nego krene prvi put metoda, a drugi broj je razmak izmedju repeticija metode (dakle svakih koliko se metoda ponovi)
    }

    void SpawnPrimitiveObject()
    {
        GameObject kockica = GameObject.CreatePrimitive(PrimitiveType.Cube);
        kockica.transform.position = new Vector3(counter, counter, 0);
        counter++;
        Debug.Log("Stvorena je " + counter + " kockica.");
    }
}
