using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GO_Zad_03 : MonoBehaviour
{
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.S))
        {
            this.gameObject.SetActive(false);
        }
    }
}
