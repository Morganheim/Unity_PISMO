using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player1CLONE : MonoBehaviour
{
    public MV2_3_GameManager gm;

    private void Start()
    {
        gm = FindObjectOfType<MV2_3_GameManager>();
    }
}
