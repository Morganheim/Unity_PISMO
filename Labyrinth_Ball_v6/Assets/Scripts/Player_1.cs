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

        if (other.gameObject.tag == "Win")
        {
            if (score >= 25)
            {
                Debug.Log("Pobjednik si!");
            }
            else if (score >= 40)
            {
                Debug.Log("Bravo majstore, pobijedio si svemir!!!");
            }
            else if (score < 25)
            {
                Debug.Log("Ti si neki speed runner, ha?");
            }

            other.gameObject.SetActive(false);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Zid")
        {
            Debug.Log("Pazi zid.");
        }
    }
}
