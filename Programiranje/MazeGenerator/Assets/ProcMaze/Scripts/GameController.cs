using System;
using UnityEngine;
using UnityEngine.SceneManagement; //dodano naknadno, nije bilo u tutorialu

[RequireComponent(typeof(MazeConstructor))]
public class GameController : MonoBehaviour
{
    public GameObject maze;

    public int rowsQuantity = 13;
    public int collumnsQuantity = 15;

    private MazeConstructor generator;

    private void Start()
    {
        generator = GetComponent<MazeConstructor>();

        generator.GenerateNewMaze(rowsQuantity, collumnsQuantity);
    }

    //moja dodana funkcionalnost za resetiranje scene i demonstraciju random generatora
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            SceneManager.LoadScene("Scene");
        }
    }
}
