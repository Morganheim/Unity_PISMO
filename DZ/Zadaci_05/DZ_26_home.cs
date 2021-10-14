using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DZ_26_home : MonoBehaviour
{
    int inventory;
    int maxInventory = 100;
    int item = 1;

    private void Start()
    {
        if(inventory > maxInventory)
        {
            inventory = maxInventory;
        }
        else if(inventory < 0)
        {
            inventory = 0;
        }

        inventory = item * 67;
        Debug.Log("Player na početku ima " + inventory + " itema u inventory-ju.");
        inventory -= item * 13;
        Debug.Log("Player izbaci 13 nepotrebnih itema iz inventory-ja i sada ima " + inventory + " itema.");
        inventory += item * 45;
        Debug.Log("Player ubije trolla i uzme mu 45 itema, te sada ima " + inventory + " itema.");
        inventory -= item * 33;
        Debug.Log("Player pregleda loot i baci 33 itema, te sada ima " + inventory + " itema.");
    }
}
