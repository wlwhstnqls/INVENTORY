using System.Collections;
using System.Collections.Generic;
using System.Data;
using UnityEngine;

public class Charater : MonoBehaviour
{
    public string Name;
    public int Level;
    public int Gold;
    public int Attack;
    public int Defense;
    public int HP;
    public int Critical;

    public void UserData(string name,int level,int gold,int attack,int defense,int hp,int critical)
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
