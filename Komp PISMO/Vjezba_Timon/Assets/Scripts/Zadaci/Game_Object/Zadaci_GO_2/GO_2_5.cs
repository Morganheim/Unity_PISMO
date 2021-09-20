using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GO_2_5 : MonoBehaviour
{
    public GameObject sfera;

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject == sfera)
        {
            this.enabled = false;
        }
    }
}
