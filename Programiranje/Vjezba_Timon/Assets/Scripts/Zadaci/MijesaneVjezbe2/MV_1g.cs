using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MV_1g : MonoBehaviour
{
    public int elfs;
    public int gnomes;
    public int orcs;

    public Text elfsText;
    public Text gnomesText;
    public Text orcsText;

    private void Start()
    {
        elfsText.text = elfs.ToString();
        gnomesText.text = gnomes.ToString();
        orcsText.text = orcs.ToString();
        InvokeRepeating("SumskaMakljaza", 0f, 3f);
    }

    public void SumskaMakljaza()
    {
        if (elfs + gnomes <= orcs)
        {
            elfs += elfs;
        }
        else if (elfs + gnomes > orcs)
        {
            gnomes -= (int)(gnomes * 0.5f);
        }
        elfsText.text = elfs.ToString();
        gnomesText.text = gnomes.ToString();
        orcsText.text = orcs.ToString();
    }
}
