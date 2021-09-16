using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DZ_2_04 : MonoBehaviour
{
    public bool activateXrotation;
    public bool activateYrotation;

    private bool odgovorD = true;

    private void Update()
    {
        if (activateXrotation)
        {
            transform.Rotate(new Vector3(3, 0, 0) * Time.deltaTime);
        }

        if (activateYrotation)
        {
            transform.Rotate(new Vector3(0, 3, 0) * Time.deltaTime);
        }

        if (activateXrotation && activateYrotation)
        {
            if (odgovorD)
            {
                Debug.Log("Rotira se i po Z osi.");
                odgovorD = false;
            }
        }
    }
}
