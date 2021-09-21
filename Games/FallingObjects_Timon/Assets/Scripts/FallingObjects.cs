using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallingObjects : MonoBehaviour
{
    //Kada nam je bool pozitvian onda nam je i objekt koji skupljamo pozitivan
    //Ako nam je negativan bool onda nam je to predmet koj izbjegavamo
    [Header("True = Good prefab | False = Bad prefab")]
    public bool isPositive = true;
    public GameManager gm;

    private void Start()
    {
        //Dodjeli game manager skriptu sa scene da se povezuje sa skriptom falling objects tako što
        //unity pretraži hiearyu i naðe koji objekt ima na sebi GameManager skritpu
        //Problem stvara ako imamo više objekata sa tom skriptom, onda ste krivo nešto napravili
        gm = FindObjectOfType<GameManager>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (isPositive)
        {
            if (other.gameObject.tag == "Player")
            {
                gm.DodajScore();
                Destroy(this.gameObject);
            }

            if (other.gameObject.tag == "Floor")
            {
                Destroy(this.gameObject);
            }
        }

        else if (!isPositive)
        {
            if (other.gameObject.tag == "Player")
            {
                gm.MakniZivot();
                Destroy(this.gameObject);
            }
            if (other.gameObject.tag == "Floor")
            {
                Destroy(this.gameObject);
            }
        }
    }
}
