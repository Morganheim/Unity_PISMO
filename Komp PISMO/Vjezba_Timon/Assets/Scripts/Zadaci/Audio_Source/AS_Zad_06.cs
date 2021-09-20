using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AS_Zad_06 : MonoBehaviour
{
    public AudioSource ass;

    [Range(0, 1)]
    public float javnaVrijednost;

    private void Start()
    {
        ass = GetComponent<AudioSource>();
    }

    private void Update()
    {
        ass.volume = javnaVrijednost;
    }
}
