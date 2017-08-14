using UnityEngine;
using System.Collections;

[System.Serializable]
public class Item 
{
    public int itemID;
    public string itemName;
    public string itemDescription;

    public Item(int id, string name, string description)
    {
        this.itemID = id;
        this.itemName = name;
        this.itemDescription = description;
    }
    public Item(int id,string name)
    {
        this.itemID = id;
        this.itemName = name;
    }
}
