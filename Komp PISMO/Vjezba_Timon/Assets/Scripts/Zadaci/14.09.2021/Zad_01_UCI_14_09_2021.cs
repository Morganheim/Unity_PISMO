using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zad_01_UCI_14_09_2021 : MonoBehaviour
{
    private void Start()
    {
        //transform.Rotate(Vector3.up)
        transform.Rotate(new Vector3(0, 1, 0));

        //transform.Rotate(Vector3.one)
        transform.Rotate(new Vector3(1, 1, 1));

        //transform.rotate(Vector2.down)
        transform.Rotate(new Vector3(0, -1, 0));

        //transform.Rotate(new Vector3(1, 0, 1));
        transform.Rotate(Vector3.right); transform.Rotate(Vector3.forward);

        //transform.position += new Vector3(1, 1, 1)
        transform.position += Vector3.one;

        //transform.localScale += new Vector3-(1, 5, 1)
        transform.localScale += new Vector3(-1, -5, -1);
    }
}
