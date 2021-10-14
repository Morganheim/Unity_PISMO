using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Invoke_SlowUpdate : MonoBehaviour
{
    [Header("Interval slow updatea")]
    public float slowUpdateInterval = 0.03f;
    float i = 0;

    private void Start()
    {
        InvokeRepeating("SlowUpdate", slowUpdateInterval, slowUpdateInterval);
    }

    void SlowUpdate()
    {
        i += Time.deltaTime;
        Debug.Log("i= " + i);
    }
}
