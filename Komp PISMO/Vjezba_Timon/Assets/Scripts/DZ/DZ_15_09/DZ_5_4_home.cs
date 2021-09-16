using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DZ_5_4_home : MonoBehaviour
{
    // 4) Napišite skriptu koja će uzeti početne vrijednosti objekta na sceni (njegov scale) i invertati ga (sve scale vrijednosti postaviti na minus)
    float scaleX;
    float scaleY;
    float scaleZ;

    private void Start()
    {
        scaleX = transform.localScale.x;
        scaleY = transform.localScale.y;
        scaleZ = transform.localScale.z;

        transform.localScale *= -1;
    }
}
