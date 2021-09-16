using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DZ_2_06 : MonoBehaviour
{
    public bool cube;
    public bool sphere;

    public float cubeRotX;
    public float cubeRotY;
    public float cubeRotZ;

    private bool cubeGrow;
    private float cubeRotation;
    private float cubeSize = 1;

    private bool sphereGrow;
    private float sphereSize = 1;

    private void Update()
    {
        if (cube)
        {
            if (cubeGrow)
            {
                cubeSize += 3 * Time.deltaTime;
                if (cubeSize >= 25)
                {
                    cubeGrow = false;
                    cubeRotation += 1;
                }
            }
            else
            {
                cubeSize -= 3 * Time.deltaTime;
                if (cubeSize <= 1)
                {
                    cubeGrow = true;
                }
            }
            transform.localScale = Vector3.one * cubeSize;


            if (cubeRotation % 2 == 0)
            {
                transform.Rotate(new Vector3(cubeRotX, cubeRotY, cubeRotZ) * Time.deltaTime);
            }
            else if (cubeRotation % 2 == 1)
            {
                transform.Rotate(new Vector3(-cubeRotX, -cubeRotY, -cubeRotZ) * Time.deltaTime);
            }

        }

        if (sphere)
        {
            if (sphereGrow)
            {
                sphereSize += 3 * Time.deltaTime;
                if (sphereSize >= 25)
                {
                    sphereGrow = false;
                }
            }
            else
            {
                sphereSize -= 3 * Time.deltaTime;
                if (sphereSize <= 1)
                {
                    sphereGrow = true;
                }
            }
            transform.localScale = Vector3.one * sphereSize;
        }
    }
}
