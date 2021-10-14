using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI_zad_01_01 : MonoBehaviour
{
    public string word;
    public Text nasUIText;
    public Image nasUIImage;
    public Button nasUIButton;

    private void Start()
    {
        nasUIText.text = word;
    }
}
