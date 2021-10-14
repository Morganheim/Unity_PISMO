using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Zad_09_03 : MonoBehaviour
{
    public Text bravoText;

    IEnumerator Bravo()
    {
        yield return new WaitForSeconds(19);
        bravoText.text = "Bravo!";
    }
}
