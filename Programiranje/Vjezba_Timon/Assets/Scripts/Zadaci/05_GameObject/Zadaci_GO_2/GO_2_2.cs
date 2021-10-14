using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GO_2_2 : MonoBehaviour
{
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.S))
        {
            Destroy(this);
        }
    }
}
