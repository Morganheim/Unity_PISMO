using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zadatak_03 : MonoBehaviour
{
    public float sveOsi;

    private void Update()
    {
        transform.Rotate(new Vector3(sveOsi, sveOsi, sveOsi) * Time.deltaTime);
    }

}
