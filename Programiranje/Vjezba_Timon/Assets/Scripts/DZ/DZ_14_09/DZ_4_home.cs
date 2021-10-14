using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DZ_4_home : MonoBehaviour
{
    float posX;
    float posY;
    float posZ;

    float rotX;
    float rotY;
    float rotZ;

    float scaleX;
    float scaleY;
    float scaleZ;

    float zbrojPos;
    float zbrojRot;
    float zbrojScale;

    private void Start()
    {
        posX = transform.position.x;
        posY = transform.position.y;
        posZ = transform.position.z;

        rotX = transform.eulerAngles.x;
        rotY = transform.eulerAngles.y;
        rotZ = transform.eulerAngles.z;

        scaleX = transform.localScale.x;
        scaleY = transform.localScale.y;
        scaleZ = transform.localScale.z;

        zbrojPos = posX + posY + posZ;
        zbrojRot = rotX + rotY + rotZ;
        zbrojScale = scaleX + scaleY + scaleZ;

        if(zbrojPos > 20 || zbrojRot > 20 || zbrojScale > 20)
        {
            transform.position = Vector3.zero;

            transform.rotation = Quaternion.Euler(0, 0, 0);
            //transform.eulerAngles = new Vector3(0, 0, 0);
            //transform.eulerAngles = Vector3.zero;

            transform.localScale = Vector3.one;
        }
        else
        {
            transform.position += new Vector3(zbrojPos, zbrojPos, zbrojPos);
            //transform.position += Vector3.one * zbrojPos;
            //transform.position += new Vector3(1, 1, 1) * zbrojPos;

            transform.eulerAngles = new Vector3(69, 420, 911);
            //transform.rotation = Quaternion.Euler(0, 0, 0);
            //transform.Rotate(new Vector3(69, 420, 911));

            transform.localScale += new Vector3(zbrojScale, zbrojScale, zbrojScale);
            //transform.localScale += Vector3.one * zbrojScale;
        }
    }
}
