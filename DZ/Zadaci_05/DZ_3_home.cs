using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DZ_3_home : MonoBehaviour
{
    public float javnaVrijednost;
    private bool grow;

    private void Start()
    {
        if(javnaVrijednost <= 100)
        {
            transform.localScale += new Vector3(javnaVrijednost, 0, 0);
        }
    }

    private void Update()
    {
        if(javnaVrijednost <= 100)
        {
            grow = true;
            if (grow)
            {
                javnaVrijednost++;
                transform.localScale += new Vector3(javnaVrijednost, javnaVrijednost, javnaVrijednost);
            }
        }
        else if(javnaVrijednost > 100)
        {
            grow = false;
        }
    }
}
