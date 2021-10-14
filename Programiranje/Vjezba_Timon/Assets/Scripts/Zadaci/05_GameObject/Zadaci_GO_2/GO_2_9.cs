using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GO_2_9 : MonoBehaviour
{
    public GameObject kocka;
    public float timer = 5;
    public int redniBrojKocke = 1;

    private void Update()
    {
        timer -= Time.deltaTime;
        if (timer <= 0)
        {
            Instantiate(kocka, new Vector3(0, redniBrojKocke, 0), Quaternion.identity);
            timer = 5;
            redniBrojKocke++;
        }
    }
}
