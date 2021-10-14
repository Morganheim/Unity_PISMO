using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI_zad_01_02 : MonoBehaviour
{
    public float maxHP;

    public Text hpText;

    float currentHP;

    private void Start()
    {
        currentHP = maxHP;
    }

    private void Update()
    {
        hpText.text = currentHP + "/" + maxHP;

        if (Input.GetKeyDown(KeyCode.A))
        {
            currentHP -= 5;
        }
    }
}
