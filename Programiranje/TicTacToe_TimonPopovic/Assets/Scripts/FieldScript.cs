using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FieldScript : MonoBehaviour
{
    //OBAVEZNO STAVITI NA SVAKI BUTTON OD 9 MOGUCIH!

    Text btnText;
    Button btn;
    GameManager gm;

    private void Start()
    {
        btn = GetComponent<Button>();
        btnText = GetComponentInChildren<Text>();
        gm = FindObjectOfType<GameManager>();
    }

    public void SetSymbol()
    {
        btnText.text = gm.side;
        btn.interactable = false;
        gm.moves++;
        gm.movesText.text = "Move: " + gm.moves; // ja dodao
        gm.EndGame();
    }
}
