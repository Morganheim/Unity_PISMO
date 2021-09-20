using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_1 : MonoBehaviour
{
    public float score = 0;


    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Cube")
        {
            score++;
            other.gameObject.SetActive(false);
        }

        if (other.gameObject.tag == "Death")
        {
            Debug.Log("Padaj zauvijek.");
        }
    }
}
