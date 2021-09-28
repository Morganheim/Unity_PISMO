using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstPlatformMovement : MonoBehaviour
{
    private void Update()
    {
        transform.position += new Vector3(0, -0.69f, 0) * Time.deltaTime;
    }
}
