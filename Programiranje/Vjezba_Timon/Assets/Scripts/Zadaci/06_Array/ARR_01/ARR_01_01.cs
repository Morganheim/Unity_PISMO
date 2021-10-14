using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ARR_01_01 : MonoBehaviour
{
    public GameObject[] prefabs;
    public Transform[] transforms;
    public int[] broj;


    private void Start()
    {
        Instantiate(prefabs[broj[0]], transforms[broj[1]], transforms[broj[1]]);
    }
}
