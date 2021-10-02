using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChooseGun : MonoBehaviour
{
    public GameObject[] guns;

    private void Start()
    {
        for(int i = 1; i < guns.Length; i++)
        {
            guns[i].SetActive(false);
        }
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            for(int i = 1; i < guns.Length; i++)
            {
                guns[i].SetActive(false);
            }
            guns[0].SetActive(true);
        }

        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            for (int i = 0; i < guns.Length; i++)
            {
                guns[i].SetActive(false);
            }
            guns[1].SetActive(true);
        }

        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            for (int i = 0; i < guns.Length; i++)
            {
                guns[i].SetActive(false);
            }
            guns[2].SetActive(true);
        }
    }
}
