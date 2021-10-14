using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_1 : MonoBehaviour
{
    public float score = 0;

    public AudioClip winSound;
    public AudioClip winSoundMega;
    public AudioClip winSoundSpeed;


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
                AudioSource.PlayClipAtPoint(winSound, transform.position);

                Debug.Log("Pobjednik si!");
            }
            else if (score >= 40)
            {
                AudioSource.PlayClipAtPoint(winSoundMega, transform.position);

                Debug.Log("Bravo majstore, pobijedio si svemir!!!");
            }
            else if (score < 25)
            {
                AudioSource.PlayClipAtPoint(winSoundSpeed, transform.position);

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
