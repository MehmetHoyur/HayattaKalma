using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Crafting : MonoBehaviour
{
    public Gui guis;

    // Start is called before the first frame update

    private void Start()
    {

    }
    // Update is called once per frame
    void Update()
    {

    }
   public void uret(int secilenitem )
    {
        if (secilenitem == 1&&guis.Metal_parca>=8)
        {
            guis.zemin += 4;
            guis.Metal_parca -= 8;
        }
    }
}
