using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_Movement : MonoBehaviour
{
    public float speed;
    public Vector3 pointA = new Vector3();
    public Vector3 pointB = new Vector3();
    void Update()
    {
    
        transform.localPosition = Vector3.Lerp(pointA, pointB, Mathf.PingPong(Time.time * speed, 1));
    }
}
