using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Item
{
    public int itemId;
    public string itemName;
    public string itemDescription;

    public Item(int id, string name, string description)
    {
        this.itemId = id;
        this.itemName = name;
        this.itemDescription = description;
    }

    public Item (int id, string name)
    {
        this.itemId = id;
        this.itemName = name;
    }
}
