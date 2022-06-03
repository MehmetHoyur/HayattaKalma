using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class EnvanterSlot : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler, IPointerDownHandler
{
    public int slotsayi;
    public Item item;
    Envanter inv;
    public Image itemicon;
    public Text itempeace;

    void Start()
    {
        inv = GameObject.FindGameObjectWithTag("Envanter").GetComponent<Envanter>();
    }

    // Update is called once per frame
    void Update()
    {
        item = inv.items[slotsayi];
        if (item.ItemName != null)
        {
            itemicon.enabled = true;
            itemicon.sprite = item.ItemIcon;
            itempeace.text = item.itemadet.ToString();
        }
        else
        {
            itemicon.enabled = false;
            itempeace.text = null;
        }
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        if (item.ItemName != null)
        {
            inv.BilgiPanelAc(item);
        }

        
    }
    public void OnPointerDown(PointerEventData eventData)
    {
        if (eventData.button.ToString() == "Left")
        {
            Debug.Log("Buradayým Dayý");
            if (!inv.tasi && item.ItemName != null)
            {
                inv.TasimaPanelAc(item);
                inv.items[slotsayi] = new Item();
            }
            else if (inv.tasi)
            {
                if (item.ItemName == null)
                {
                    inv.items[slotsayi] = inv.tasinanItem;
                    inv.TasimaPanelKapa();
                }
                else
                {
                    if (item.ItemName == inv.tasinanItem.ItemName)
                    {
                        if (item.itemtip == Item.ItemType.Tool || item.itemtip == Item.ItemType.Energy)
                        {
                            inv.items[slotsayi].itemadet += inv.tasinanItem.itemadet;
                            inv.TasimaPanelKapa();
                        }
                    }

                    else
                    {
                        Item newitem = inv.items[slotsayi];
                        inv.items[slotsayi] = inv.tasinanItem;
                        inv.tasinanItem = newitem;
                    }
                }
            }
        }

        if (eventData.button.ToString() == "Right")
        {
            if (!inv.tasi)
            {
                if (item.itemtip == Item.ItemType.Energy)
                {
                    if (item.itemadet > 1)
                    {
                        int deger = item.itemadet / 2;
                        Item newItem = new Item(item.ItemName, item.Description, item.itemid, deger, item.itemstack, item.itemtip);
                        inv.TasimaPanelAc(newItem);
                        int deger2 = item.itemadet - deger;
                        inv.items[slotsayi].itemadet = deger;
                    }
                }

            }
        }

    }
    public void OnPointerExit(PointerEventData eventData)
    {
        inv.BilgiPanelKapa();
    }


}
