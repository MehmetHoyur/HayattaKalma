using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pisirme : MonoBehaviour
{
    public Gui gi;
    public int pismesuresi=10;
    public void MetalPisir()
    {
        while (pismesuresi > 0)
        {
            pismesuresi--;
        }
        if (pismesuresi == 0)
        {
            gi.Metal_parca--;
            //demir+=2;
            //organikYag+=1;
            pismesuresi--;
        }

    }


}
