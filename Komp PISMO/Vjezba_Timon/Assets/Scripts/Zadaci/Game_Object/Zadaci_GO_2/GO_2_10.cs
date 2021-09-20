using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GO_2_10 : MonoBehaviour
{
    public float timer = 5;

    private void Update()
    {
        timer -= Time.deltaTime;
        if (timer <= 0)
        {
            Debug.Log("Ja sam magarac.");
            timer = 5;
        }
    }
}
