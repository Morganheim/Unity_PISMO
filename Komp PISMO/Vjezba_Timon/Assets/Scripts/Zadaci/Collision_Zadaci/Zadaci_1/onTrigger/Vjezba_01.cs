using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//kako bi on trigger radiio barem jedan od objekata mora imati rigidbody
//barem jedan objekt mora imati ukljucen isTriggered

public class Vjezba_01 : MonoBehaviour
{
    public float health = 100;
    private void OnTriggerEnter(Collider other) //u zagradi je "argument metode"
    {
        //izvrsava samo jednom i to u frameu kada drugi objekt uðe u drugi objekt bar sa 1 pixel
        Debug.Log("ušao");
    }

    private void OnTriggerStay(Collider marmun)
    {
        //izvrsava se svaki frame dok god je objekt unutar drugog objekta
        Debug.Log("unutra");
        if (marmun.gameObject.tag == "SafeZone")
        {
            health += 10 * Time.deltaTime;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        //izvrsava se samo jednom i to u frameu kada objekt u potpunosti izaðe iz drugog (sa zadnjim pixelom)
        Debug.Log("izašao");
    }
}
