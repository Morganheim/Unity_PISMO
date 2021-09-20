using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GO_2_5 : MonoBehaviour
{

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.name == "Sfera")
        {
            this.enabled = false;
        }
    }
}
