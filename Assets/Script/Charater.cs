using System.Collections;
using System.Collections.Generic;
using System.Data;
using UnityEngine;

public class Charater 
{
    public string Name { get; private set; }
    public int Level { get; private set; }
    public int Gold { get; private set; }
    public int Attack { get; private set; }
    public int Defense { get; private set; }
    public int HP { get; private set; }
    public int Critical { get; private set; }



    public Charater (string name,int level,int gold,int attack,int defense,int hp,int critical)
    {
        Name = name;
        Level = level;
        Gold = gold;
        Attack = attack;
        Defense = defense;
        HP = hp;
        Critical = critical;
    }
}
