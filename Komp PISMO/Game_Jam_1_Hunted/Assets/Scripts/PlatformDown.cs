using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformDown : MonoBehaviour
{
    void Update()
    {
        transform.position += new Vector3(0, -2, 0) * Time.deltaTime;
    }
}
