using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MV2_3_UIManager : MonoBehaviour
{
    [Header("Player info")]
    public Text playerText;
    public InputField player1Name;
    public InputField player2Name;

    [Header("Timer")]
    public Text timerText;

    [Header("Game info texts")]
    public Text rulesText;
    public Text controlsText;

    [Header("End game info")]
    public GameObject endGamePanel;
    public Text endGameText;

    [Header("Other Scripts")]
    public MV2_3_GameManager gm;
    public MazeLoader generator;

    private void Start()
    {
        gm = FindObjectOfType<MV2_3_GameManager>();

        timerText.text = gm.timer.ToString();
    }
}
