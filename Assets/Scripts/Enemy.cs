using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    // Public Vars
    public string enName;
    public int health;
    public int speed;
    public int defense;
    public Attack[] attacks;

    // Constructor
    public Enemy(string name, int hp, int sp, int def)
    {
        this.enName = name;
        health = hp;
        speed = sp;
        defense = def;
    }

    // Adds an attack
    
}
