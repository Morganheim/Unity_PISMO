using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coins : MonoBehaviour
{
    public float speed;

    private void Update()
    {
        transform.Rotate(Vector3.right * speed * Time.deltaTime);
    }
}
