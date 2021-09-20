using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GO_2_8 : MonoBehaviour
{
    public GameObject kocka;
    public float timer = 10;

    private void Update()
    {
        timer -= Time.deltaTime;
        if (timer <= 0)
        {
            Instantiate(kocka, Vector3.zero, new Quaternion());
            timer = 10;
        }
    }
}
