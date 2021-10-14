using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ARR_Primjer : MonoBehaviour
{
    public int redniBrojStvaranja;
    public GameObject[] prefabs;
    public string[] userNames;

    private void Start()
    {
        Instantiate(prefabs[redniBrojStvaranja], Vector3.zero, Quaternion.identity);
        Debug.Log("Player" + userNames[redniBrojStvaranja] + "stvorio je" + prefabs[redniBrojStvaranja].name);
    }
}
