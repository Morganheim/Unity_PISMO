using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zadatak_09 : MonoBehaviour
{
    public float scaleX;
    public float scaleY;
    public float scaleZ;
    public float rotX;
    public float rotY;
    public float rotZ;
    public float posX;
    public float posY;
    public float posZ;

    private void Update()
    {
        transform.position += new Vector3(posX, posY, posZ) * Time.deltaTime;
        transform.localScale += new Vector3(scaleX, scaleY, scaleZ) * Time.deltaTime;
        transform.Rotate(new Vector3(rotX, rotY, rotZ) * Time.deltaTime);
    }
}
