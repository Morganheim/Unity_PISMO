using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_Movement_iso : MonoBehaviour
{
    public GameManager_iso gm;
    public GameObject target;
    public float speed;

    [Range(1, 4)]
    public int enemyType;

    private void Start()
    {
        gm = FindObjectOfType<GameManager_iso>();
        target = GameObject.FindGameObjectWithTag("Player");
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Wall")
        {
            gm.DodajScore();
            Destroy(this.gameObject);
        }

        if (collision.gameObject.tag == "Player")
        {
            gm.MakniLife();
        }
    }

    private void Update()
    {
        transform.LookAt(target.transform);
        transform.position = Vector3.MoveTowards(transform.position, target.transform.position, speed);
    }
}
