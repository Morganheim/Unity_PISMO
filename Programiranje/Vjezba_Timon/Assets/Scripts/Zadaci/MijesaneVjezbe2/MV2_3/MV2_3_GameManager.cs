using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MV2_3_GameManager : MonoBehaviour
{
    [Header("Player info")]
    public GameObject player1;
    public GameObject player1Clone; //prefab koji se postavi na poziciju playera 1 i s kojim player 2 moze interaktirati ako ga "ulovi"
    public GameObject player2;

    [Header("Timer info")]
    public float timer;
    public bool player1Playing; //ako je true - player 1 igra, ako je false - player 2 igra

    [Header("Scripts to call")]
    public MV2_3_MusicManager mm;
    public MV2_3_UIManager uim;
    public MazeLoader generator;

    [Header("UI")]
    public Text playerName;
    public Slider rowSlider;
    public Text rowSliderText;
    public Slider columnSlider;
    public Text columnSliderText;

    private void Start()
    {
        mm = FindObjectOfType<MV2_3_MusicManager>();
        uim = FindObjectOfType<MV2_3_UIManager>();
        generator = FindObjectOfType<MazeLoader>();

        //player1.SetActive(true);
        //player2.SetActive(false);
        player1Playing = true;

        mm.MenuMusic();

        rowSlider.maxValue = 99;
        rowSlider.minValue = 5;
        columnSlider.maxValue = 99;
        columnSlider.minValue = 5;
        rowSlider.value = generator.mazeRows;
        columnSlider.value = generator.mazeColumns;

        TimerSet();

        InvokeRepeating("NameTextUpdate", 0f, 0.03f);

        InvokeRepeating("MazeSize", 0f, 0.03f);
    }

    private void Update()
    {
        if (timer == 0 && player1Playing)
        {
            PlayerSet();
        }

        if (Input.GetKeyDown(KeyCode.K))
        {
            timer -= 45;
        }
    }

    public void GameStart()
    {
        //generator.GenerateStartPoint();
        //player1.transform.position = generator.startPoint.transform.position;
        //player2.transform.position = generator.startPoint.transform.position;
        InvokeRepeating("Timer", 0f, 1f);
    }

    public void TimerSet()
    {
        if (player1Playing)
        {
            timer = 60;
        }
        else
        {
            timer = 300;
        }
    }

    public void Timer()
    {
        if (timer > 0)
        {
            timer--;
            uim.timerText.text = timer.ToString();
        }
    }

    public void PlayerSet()
    {
        if (timer == 0 && player1Playing)
        {
            player1Playing = false;
            TimerSet();
            //Instantiate(player1Clone, player1.transform.position, Quaternion.identity);
            //player1.SetActive(false);
            //player2.SetActive(true);
            mm.GameMusic();
        }
    }

    public void NameTextUpdate()
    {
        if (player1Playing)
        {
            playerName.text = uim.player1Name.text;
        }
        else
        {
            playerName.text = uim.player2Name.text;
        }
    }

    public void MazeSize()
    {
        generator.mazeRows = (int)rowSlider.value;
        rowSliderText.text = generator.mazeRows.ToString();
        generator.mazeColumns = (int)columnSlider.value;
        columnSliderText.text = generator.mazeColumns.ToString();
    }

    public void PauseGame()
    {
        Time.timeScale = 0;
        CancelInvoke();
    }

    public void ResumeGame()
    {
        Time.timeScale = 1;
        InvokeRepeating("Timer", 0f, 1f);
    }

    public void QuitGame()
    {
        Application.Quit();
        Debug.Log("Shut Down Game");
    }

    public void Player2Win()
    {
        uim.endGamePanel.SetActive(true);
        uim.endGameText.text = uim.player2Name.text + ", the Seeker WINS!!!!!";
    }

    public void Player1Win()
    {
        uim.endGamePanel.SetActive(true);
        uim.endGameText.text = uim.player1Name.text + ", the Hider WINS!!!!!";
    }
}
