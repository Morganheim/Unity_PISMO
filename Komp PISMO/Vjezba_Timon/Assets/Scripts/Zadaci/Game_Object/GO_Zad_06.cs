using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GO_Zad_06 : MonoBehaviour
{
    public AudioSource ass;

    private void Start()
    {
        ass = GetComponent<AudioSource>();

        ass.Play();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.P))
        {
            this.gameObject.SetActive(!this.gameObject);
        }
    }
}
