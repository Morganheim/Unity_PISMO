using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zad_03_2_UCI_14_09_2021 : MonoBehaviour
{
    //a)    5 cubeova, 6 sphere, 8 capsule, 2 plane     DONE

    //b)    10 razlicitih materijala        DONE

    //c)    obojite objekte po izboru       DONE

    //d)    nemjesti kameru da obuhvaca sve objekte pogledom i solid color umjesto skybox       DONE

    //e)    skripta uvecava ili smanjuje objekte ovisno o javnim vrijednostima u sekundi        DONE

    //f)    nova skripta za rotaciju po javnim vrijednostima u sekundi      DONE

    //g)    nadogradi skripte e i f naredbom koja mijenja poziciju objekta za javne vrijednosti unesene (zbroje ili oduzmu) ovisno o tome
    //je li se objekt povecavao ili smanjivao
    //i je li se rotirao pozitivno ili negativno

    //h)    ako se objekt smanjio za duplo ili zarotirao cijeli krug negativno neka se pomakne za unesenu vrijednost iz zadatka g
    //ili ako se povecao za duplo ili zarotirao cijeli krug pozitivno neka se pomakne za vrijednost iz zadatka g





    //f)
    public float rotObjectX;
    public float rotObjectY;
    public float rotObjectZ;

    public bool rotatingPositive;

    //g)
    public float posObjectX;
    public float posObjectY;
    public float posObjectZ;

    private void Update()
    {
        if (rotatingPositive)
        {
            transform.Rotate(new Vector3(rotObjectX, rotObjectY, rotObjectZ) * Time.deltaTime);
            //g
            transform.position += new Vector3(posObjectX, posObjectY, posObjectZ);
        }
        else
        {
            transform.Rotate(new Vector3(-rotObjectX, -rotObjectY, -rotObjectZ) * Time.deltaTime);
            //g
            transform.position -= new Vector3(posObjectX, posObjectY, posObjectZ);
        }

    }
}
