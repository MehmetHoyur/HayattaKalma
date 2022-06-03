using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataItem : MonoBehaviour
{
    public List<Item> itemler;
    public void Awake()
    {
        itemler.Add(new Item("Bos", "", 10000, 0, 0, Item.ItemType.Empty));
        itemler.Add(new Item("Spray", "Can Basar", 0, 1, 1, Item.ItemType.Energy));
        itemler.Add(new Item("battery", "Kayýp Enerjiyi Yeniler", 1, 1, 36, Item.ItemType.Energy));

        itemler.Add(new Item("Zemin", "Evi Yapabilmek Ýçin Önce Zemin Ekle", 2, 1 , 36, Item.ItemType.Energy));
    }

}
