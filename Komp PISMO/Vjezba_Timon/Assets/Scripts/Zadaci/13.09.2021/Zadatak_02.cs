using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zadatak_02 : MonoBehaviour
{
    private void Update()
    {
        transform.Rotate(new Vector3(1, 1, 1) * Time.deltaTime);
    }
}
