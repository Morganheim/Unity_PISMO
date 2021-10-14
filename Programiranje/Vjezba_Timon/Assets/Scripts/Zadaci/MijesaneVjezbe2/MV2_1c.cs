using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MV2_1c : MonoBehaviour
{
    public float pokrajine;
    public int coins;

    public Text pokrajineText;
    public Text coinsText;

    private void Start()
    {
        InvokeRepeating("CoinAdd", 0f, 1f);
    }

    public void CoinAdd()
    {
        coins += (int)(pokrajine);
        pokrajineText.text = "Pokrajine: " + (int)pokrajine;
        coinsText.text = "Coins: " + coins;
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.D))
        {
            pokrajine *= 0.5f;
            pokrajineText.text = "Pokrajine: " + (int)pokrajine;
        }
        if (Input.GetKeyDown(KeyCode.A))
        {
            pokrajine += Random.Range(1, 6);
            pokrajineText.text = "Pokrajine: " + (int)pokrajine;
        }
    }
}
