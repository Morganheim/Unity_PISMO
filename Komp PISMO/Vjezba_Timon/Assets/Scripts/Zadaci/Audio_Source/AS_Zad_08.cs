using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AS_Zad_08 : MonoBehaviour
{
    public AudioSource prvi;
    public AudioSource drugi;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (prvi.enabled)
            {
                prvi.enabled = false;
                drugi.enabled = true;
            }
            else if (drugi.enabled)
            {
                prvi.enabled = true;
                drugi.enabled = false;
            }
        }
    }
}
