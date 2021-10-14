using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TransformScale : MonoBehaviour
{
    public float scaleX;
    public float scaleY;
    public float scaleZ;
    private void Update()
    {
        transform.localScale += new Vector3(scaleX, scaleY, scaleZ);
    }

}
