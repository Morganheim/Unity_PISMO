using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zadatak_5 : MonoBehaviour
{
    public float javnaVrijednost;

    private void Update()
    {
        transform.Rotate(Vector3.up * javnaVrijednost);
    }
}
