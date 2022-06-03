using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Envanter : MonoBehaviour
{
    public List<Item> items;

    public int baslangicmiktar, slotmiktar;
    public GameObject slot, bilgiPanel, TasimaPanel;
    DataItem dataitem;
    public bool info, tasi;
    public Item bilgiItem, tasinanItem;
    void Start()
    {
        dataitem = GameObject.FindGameObjectWithTag("DataItem").GetComponent<DataItem>();
        for (int i = baslangicmiktar; i < slotmiktar; i++)
        {
            GameObject slotobje = (GameObject)Instantiate(slot);
            slotobje.transform.SetParent(gameObject.transform);
            slotobje.GetComponent<EnvanterSlot>().slotsayi = i;
        }
        for (int i = 0; i < slotmiktar; i++)
        {
            items.Add(new Item());
        }

        itemEkle(0, 5);
        itemEkle(1, 5);
        itemEkle(0, 2);
        itemEkle(2, 3);
    }

    // Update is called once per frame

    public void itemEkle(int id, int miktar)
    {
        for (int i = 0; i < dataitem.itemler.Count; i++)
        {
            if (dataitem.itemler[i].itemid == id)
            {
                Item newItem = new Item(dataitem.itemler[i].ItemName, dataitem.itemler[i].Description,
                    dataitem.itemler[i].itemid, dataitem.itemler[i].itemadet, dataitem.itemler[i].itemstack, dataitem.itemler[i].itemtip);


                if (newItem.itemtip == Item.ItemType.Energy || newItem.itemtip == Item.ItemType.Tool)
                {
                    stackle(newItem);
                }
                else if (newItem.itemadet > 1)
                {
                    int deger = newItem.itemadet - 1;
                    Item newitem2 = new Item(newItem.ItemName, newItem.Description,
                   newItem.itemid, deger, newItem.itemstack, newItem.itemtip);
                    newitem2.itemadet = 1;

                    BosSlotEkle(newItem);
                }
                else
                {
                    BosSlotEkle(newItem);
                }
                Debug.Log("burdayým");

            }

        }
    }
    public void stackle(Item item)
    {
        for (int i = 0; i < items.Count; i++)
        {
            if (items[i].ItemName == item.ItemName)
            {
                items[i].itemadet += item.itemadet;
                break;
            }
            if (i == items.Count - 1)
            {
                BosSlotEkle(item);
            }
        }
    }
    public void BosSlotEkle(Item item)
    {
        for (int i = 0; i < items.Count; i++)
        {
            if (items[i].ItemName == null)
            {
                items[i] = item;
                break;
            }
        }

    }

    public void BilgiPanelAc(Item item)
    {
        info = true;
        bilgiItem = item;

    }
    public void BilgiPanelKapa()
    {
        info = false;
        bilgiItem = null;

    }
    public void TasimaPanelAc(Item item)
    {
        tasi = true;
        tasinanItem = item;
    }
    public void TasimaPanelKapa()
    {
        tasi = false;
        tasinanItem = null;
        TasimaPanel.SetActive(false);
    }
    private void Update()
    {
        if (info)
        {
            bilgiPanel.GetComponent<RectTransform>().position = new Vector2(Input.mousePosition.x, Input.mousePosition.y);
            bilgiPanel.SetActive(true);
            bilgiPanel.transform.GetChild(0).GetComponent<Text>().text = bilgiItem.ItemName;
            bilgiPanel.transform.GetChild(1).GetComponent<Text>().text = bilgiItem.Description;

        }
        else
        {
            bilgiPanel.SetActive(false);

        }
        if (tasi)
        {
            TasimaPanel.SetActive(true);
            TasimaPanel.GetComponent<RectTransform>().position = new Vector2(Input.mousePosition.x, Input.mousePosition.y);
            TasimaPanel.transform.GetChild(0).GetComponent<Image>().sprite = tasinanItem.ItemIcon;

        }

    }
}
