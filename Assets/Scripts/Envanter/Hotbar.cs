using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Hotbar : MonoBehaviour
{
    public List<GameObject> slotlar;
    public int slotsayi;
    public Sprite secliliSlot, bosSlot;
    Envanter inv;
    TutulanItem tut;
    void Start()
    {
        inv = GameObject.FindGameObjectWithTag("Envanter").GetComponent<Envanter>();
        tut = GameObject.FindGameObjectWithTag("MainCamera").GetComponent<TutulanItem>();
    }

    // Update is called once per frame
    void Update()
    {
        iconBelirle();
        slotsayiBelirle();
        itemSec(inv.items[slotsayi]);
    }
    void slotsayiBelirle()
    {
        if (Input.GetKeyDown(KeyCode.Alpha8))
        {
            slotsayi = 7;
        }
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            slotsayi = 0;
        }
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            slotsayi =
                1;

        }
        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            slotsayi = 2;
        }
        if (Input.GetKeyDown(KeyCode.Alpha4))
        {
            slotsayi = 3;
        }
        if (Input.GetKeyDown(KeyCode.Alpha5))
        {
            slotsayi = 4;
        }
        if (Input.GetKeyDown(KeyCode.Alpha6))
        {
            slotsayi = 5;
        }
        if (Input.GetKeyDown(KeyCode.Alpha7))
        {
            slotsayi = 6;
        }

    }
    void iconBelirle()
    {
        for (int i = 0; i < slotlar.Count; i++)
        {
            slotlar[i].GetComponent<Image>().sprite = bosSlot;

        }
        slotlar[slotsayi].GetComponent<Image>().sprite = secliliSlot;
    }
    void itemSec(Item item)
    {
        for (int i = 0; i < tut.Objeler.Count; i++)
        {
            if (tut.Objeler[i].name == item.ItemName)
            {
                tut.Objeler[i].SetActive(true);
            }
            else
            {
                tut.Objeler[i].SetActive(false);
            }
        }
    }
}
