using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyKill : MonoBehaviour
{
    public GameManager gm;

    private void Start()
    {
        gm = FindObjectOfType<GameManager>();
    }

    public GameObject enemy;
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Destroy(enemy.gameObject);
            gm.ScoreUp();
            gm.life++;
        }
    }
}
