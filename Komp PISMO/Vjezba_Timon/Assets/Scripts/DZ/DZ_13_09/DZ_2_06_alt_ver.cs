using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DZ_2_06_alt_ver : MonoBehaviour
{
    private float changeXYZ = 3;

    public float rotX;
    public float rotY;
    public float rotZ;

    bool expand;

    private void Update()
    {
        if (transform.localScale.x <= 1 || transform.localScale.y <= 1 || transform.localScale.z <= 1)
        {
            expand = true;
        }
        else if (transform.localScale.x >= 25 || transform.localScale.y >= 25 || transform.localScale.z >= 25)
        {
            expand = false;
        }

        if (expand)
        {
            transform.localScale += new Vector3(changeXYZ, changeXYZ, changeXYZ) * Time.deltaTime;
            transform.Rotate(new Vector3(rotX, rotY, rotZ) * Time.deltaTime);
        }
        else if (!expand)
        {
            transform.localScale -= new Vector3(changeXYZ, changeXYZ, changeXYZ) * Time.deltaTime;
            transform.Rotate(new Vector3(-rotX, -rotY, -rotZ) * Time.deltaTime);
        }
    }
}
