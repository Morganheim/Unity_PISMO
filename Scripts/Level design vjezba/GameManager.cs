using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public int pickedArtefacts;
    public GameObject[] artifacts;
    public UIManager uiM;

    private void Start()
    {
        uiM = FindObjectOfType<UIManager>();
        artifacts = GameObject.FindGameObjectsWithTag("Artefact");
        //Želim da mi ispiše koliko od koliko artifekata imam - to treba napraviti UI Manager
        uiM.UpdateText(pickedArtefacts, artifacts.Length);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Artefact")
        {
            pickedArtefacts++;
            uiM.UpdateText(pickedArtefacts, artifacts.Length);
            if (pickedArtefacts == artifacts.Length)
            {
                uiM.ShowEndGame(pickedArtefacts);
                Time.timeScale = 0;
                //GameObject player = GameObject.FindGameObjectWithTag("Player");
                //player.SetActive(false);
            }
            other.gameObject.SetActive(false);
        }
    }




    public bool pause;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.P))
        {
            pause = !pause;
            if (pause)
            {
                Time.timeScale = 0;
            }
            else if (!pause)
            {
                Time.timeScale = 1;
            }
        }
    }




}
