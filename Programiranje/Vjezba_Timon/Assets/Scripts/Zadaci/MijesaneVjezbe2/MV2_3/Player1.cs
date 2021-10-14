using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player1 : MonoBehaviour
{
    public MV2_3_GameManager gm;

    private void Start()
    {
        gm = FindObjectOfType<MV2_3_GameManager>();
    }
    private void Update()
    {
        if (gm.player1Playing)
        {
            if (Input.GetKeyDown(KeyCode.O))
            {
                gm.timer = 0;
                gm.PlayerSet();
            }
        }
    }
}
