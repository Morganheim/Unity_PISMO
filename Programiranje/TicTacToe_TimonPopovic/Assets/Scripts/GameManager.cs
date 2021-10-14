using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GameManager : MonoBehaviour
{
    [Header("Array polja za x i o")]
    public Text[] fieldList; //tekst na buttonima u gridu, gdje ce pisati X ili O

    [Header("Game over panel")]
    public GameObject gameOverPanel;

    [Header("Active Game Panel")]
    public Text player1Name;
    public Text player2Name;
    public InputField player1InputName;
    public InputField player2InputName;
    public Text player1Score;
    public Text player2Score;
    public Text movesText;

    [Header("Other / X & O")]
    public string side; //moze imati vrijednost x ili o
    public int moves = 1; //na kojem smo potezu

    [Header("Music Manager")]
    public MusicManager mm;
    public bool tie; //bool koji govori je li tie ili nije, a poziva se u MusicManageru

    private void Start()
    {
        gameOverPanel.SetActive(false);
        side = "X"; //prvi igrac uvijek krece sa X
        moves = 1; //prvi potez

        for (int i = 0; i < fieldList.Length; i++)
        {
            fieldList[i].text = ""; //da ocisti sto pise na buttonu (u gridu)
            fieldList[i].GetComponentInParent<Button>().interactable = true; //aktiviramo button da mozemo igrati
        }

        movesText.text = "Move: " + moves;

        tie = false;

        mm = FindObjectOfType<MusicManager>();
        mm.MainMenuMusic();
    }

    //metoda koja mijenja tko je na potezu
    public void ChangeSide()
    {
        if (side == "X")
        {
            side = "O";
        }
        else
        {
            side = "X";
        }
    }

    //metoda sa kojom provjeravamo imamo li pobjednika
    public void EndGame()
    {
        //0, 1, 2
        if (fieldList[0].text == side && fieldList[1].text == side && fieldList[2].text == side)
        {
            CheckWin();
        }
        //3, 4, 5
        if (fieldList[3].text == side && fieldList[4].text == side && fieldList[5].text == side)
        {
            CheckWin();
        }
        //6, 7, 8
        if (fieldList[6].text == side && fieldList[7].text == side && fieldList[8].text == side)
        {
            CheckWin();
        }
        //0, 3, 6
        if (fieldList[0].text == side && fieldList[3].text == side && fieldList[6].text == side)
        {
            CheckWin();
        }
        //1, 4, 7
        if (fieldList[1].text == side && fieldList[4].text == side && fieldList[7].text == side)
        {
            CheckWin();
        }
        //2, 5, 8
        if (fieldList[2].text == side && fieldList[5].text == side && fieldList[8].text == side)
        {
            CheckWin();
        }
        //0, 4, 8
        if (fieldList[0].text == side && fieldList[4].text == side && fieldList[8].text == side)
        {
            CheckWin();
        }
        //2, 4, 6
        if (fieldList[2].text == side && fieldList[4].text == side && fieldList[6].text == side)
        {
            CheckWin();
        }

        ChangeSide();

        // ja dodao naknadno i proradila je stvar
        if (moves > 9)
        {
            CheckWin();
        }

    }

    //nakon sto smo postavili 3 u nizu ista znaka ili je nerijeseno, pali game over panel i reci rezultat
    void CheckWin()
    {
        gameOverPanel.SetActive(true);

        //ako je 10. potez koji je nemoguc, dakle nerijeseno je
        if (moves > 9)
        {
            gameOverPanel.GetComponentInChildren<Text>().text = "TIE!";
            tie = true;
            mm.OverMusic();
        }

        //ako je X pobijedio, odnosno player 1
        else if (moves % 2 == 0)
        {
            gameOverPanel.GetComponentInChildren<Text>().text = player1Name.text + " WINS!!!!!";
            //u ukupni rezultat spremi pobjedu prvoga
            mm.OverMusic();
        }

        //ako je O pobijedio, odnosno player 2
        else
        {
            gameOverPanel.GetComponentInChildren<Text>().text = player2Name.text + " WINS!!!!!";
            // u ukupni rez spremi pobjedu drugog
            mm.OverMusic();
        }
    }

    //poziva se na play gumb kad ase unesu imena
    public void SetUpNames()
    {
        //promijeni imena iskljucivo ako su unesene nove vrijednosti za imena
        if (player1InputName.text != "" && player2InputName.text != "")
        {
            player1Name.text = player1InputName.text;
            player2Name.text = player2InputName.text;

        }
    }

    //resetiram igru
    public void ResetGame()
    {
        Start();
    }
}
