using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZaRijesiti_11_10_21 : MonoBehaviour
{
    private void Start()
    {
        GameObject cube = GameObject.CreatePrimitive(PrimitiveType.Cube);

        cube.AddComponent(typeof(Rigidbody));
        cube.AddComponent(typeof(ZaRijesitiRigi_11_10_21));

        cube.transform.Rotate(Vector3.zero);
        cube.transform.localScale = Vector3.one * 2;
        cube.transform.position = Vector3.zero;
    }
}
