using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformMOve : MonoBehaviour
{
    private void Update()
    {
        transform.Rotate(new Vector3(0.005f, 0, 0));
    }
}
