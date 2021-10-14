using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TransformRotate : MonoBehaviour
{
    public float rotX;
    public float rotY;
    public float rotZ;
    private void Update()
    {
        transform.Rotate(new Vector3(rotX, rotY, rotZ));
    }
}
