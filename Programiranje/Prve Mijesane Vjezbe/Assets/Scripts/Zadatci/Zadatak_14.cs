using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Zadatak_14 : MonoBehaviour
{
    public string javniText;

    public Text ispisaniText;

    private void Update()
    {
        ispisaniText.text = javniText;
    }
}
