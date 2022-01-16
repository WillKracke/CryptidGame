using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attack
{
    public string attackName;
    public int accuracy;
    public int damage;
    public bool debuff;

    // Constructor
    public Attack(string name, int acc, int dmg, bool deb)
    {
        attackName = name;
        accuracy = acc;
        damage = dmg;
        debuff = deb;
    }
}
