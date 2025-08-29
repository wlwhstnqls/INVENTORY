using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item 
{
    public string itemName { get; private set; }
    public int itematk { get; private set; }
    public int itemdef { get; private set; }
    public int itemhp { get; private set; }
    public int itemcritical { get; private set; }

    public Item(string name, int atk, int def, int hp, int critical)
    {
        itemName = name;
        itematk = atk;
        itemdef = def;
        itemhp = hp;
        itemcritical = critical;
    }

}
