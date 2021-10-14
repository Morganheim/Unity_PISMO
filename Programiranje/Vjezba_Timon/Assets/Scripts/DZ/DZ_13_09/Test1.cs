using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test1 : MonoBehaviour
{
    public bool isCube;

    public float cubeRotationSpeedX;
    public float cubeRotationSpeedY;
    public float cubeRotationSpeedZ;

    bool isGrowing = true;
    float scaleValue = 1;

    void Update()
    {
        if (isGrowing)
        {
            scaleValue += 3 * Time.deltaTime;
            if (scaleValue >= 25)
            {
                isGrowing = false;
                scaleValue = 25;
            }
        }
        else
        {
            scaleValue -= 3 * Time.deltaTime;
            if (scaleValue <= 1)
            {
                isGrowing = true;
                scaleValue = 1;
            }
        }
        transform.localScale = Vector3.one * scaleValue;

        if (isCube)
        {
            if (isGrowing)
            {
                transform.Rotate(new Vector3(cubeRotationSpeedX, cubeRotationSpeedY, cubeRotationSpeedZ) * Time.deltaTime);
            }
            else
            {
                transform.Rotate(new Vector3(-cubeRotationSpeedX, -cubeRotationSpeedY, -cubeRotationSpeedZ) * Time.deltaTime);
            }
        }
    }
}
