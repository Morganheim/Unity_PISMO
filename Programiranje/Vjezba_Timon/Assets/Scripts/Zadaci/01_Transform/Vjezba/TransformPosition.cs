using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TransformPosition : MonoBehaviour
{
    public float posX;
    public float posY;
    public float posZ;
    private void Update()
    {
        transform.position += new Vector3(posX, posY, posZ);
    }
}
