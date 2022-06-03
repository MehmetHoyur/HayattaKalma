using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class kullanim : MonoBehaviour
{
    public Gui gi;
    public Text uyari;
    public float sayac;
    public void SpayKullan()
    {

        if (gi.spray > 0 && gi.health <= 100)
        {
            gi.health += 25;
            gi.spray--;
        }
         if (gi.health >= 100)
        {
            sayac = 10;
            if (sayac > 0)
            {
                uyari.text = "Canýnýz Zaten Dolu";
            }
            if (sayac == 0)
            {
                uyari.text = "";
            }
           
        }
         if (gi.spray <= 0)
        {
            sayac = 10;
            if (sayac > 0)
            {
                uyari.text = "Sprayiniz Yok";
            }
            if (sayac <= 0)
            {
                uyari.text = "";
            }
           

        }
       

    }
    public void bataryaKullan()
    {
        if (gi.batarya > 0 && gi.stamina <= 100)
        {
            gi.stamina += 25;
            gi.batarya--;
        }
        if (gi.stamina >= 100)
        {
            sayac = 10;
            if (sayac > 0)
            {
                uyari.text = "Enerjiniz Zaten Dolu";
            }
            if (sayac == 0)
            {
                uyari.text = "";
            }
            while (sayac > 0)
            {
                sayac--;
            }
        }
        if (gi.batarya <= 0)
        {
            sayac = 10;
            if (sayac > 0)
            {
                uyari.text = "Sprayiniz Yok";
            }
            if (sayac <= 0)
            {
                uyari.text = "";
            }

        }
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            uyari.text = " ";
        }
    }

}
