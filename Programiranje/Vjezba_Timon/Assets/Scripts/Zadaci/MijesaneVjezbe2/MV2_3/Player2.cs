using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player2 : MonoBehaviour
{
    public MV2_3_GameManager gm;

    private void Start()
    {
        gm = FindObjectOfType<MV2_3_GameManager>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "CLONE")
        {
            gm.Player2Win();
        }
    }

    private void Update()
    {
        if (gm.timer <= 0)
        {
            gm.Player1Win();
        }
    }
}
