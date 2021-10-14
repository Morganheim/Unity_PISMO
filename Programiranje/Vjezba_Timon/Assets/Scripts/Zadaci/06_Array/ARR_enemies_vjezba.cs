using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ARR_enemies_vjezba : MonoBehaviour
{
    public GameObject target; //recimo da smo to mi
    public float speed; //

    private void Start()
    {
        target = GameObject.FindGameObjectWithTag("Player");
    }

    private void Update()
    {
        transform.LookAt(target.transform);
        transform.position = Vector3.MoveTowards(transform.position, target.transform.position, speed);
    }
}
