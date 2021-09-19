using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WIN_Rot : MonoBehaviour
{
    private void Update()
    {
        transform.Rotate(Vector3.up * 42 * Time.deltaTime);
    }
}
