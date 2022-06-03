using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Item 
{
    public string ItemName;
    public string Description;
    public int itemid, itemadet, itemstack;
    public Sprite ItemIcon;
    public GameObject ItemModel;

    public ItemType itemtip;
    public enum ItemType
    {

        Tool,
        Energy,
        Empty

    }

    public Item(string name, string aciklama, int id, int adet, int stack, ItemType type)
    {
        ItemName = name;
        Description = aciklama;
        itemid = id;

        itemadet = adet;
        itemstack = stack;
        itemtip = type;
        ItemIcon = Resources.Load<Sprite>(id.ToString());
        ItemModel = Resources.Load<GameObject>("Spray");
    }

    public Item()
    {

    }
}
