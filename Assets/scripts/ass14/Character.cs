using System;
using System.Collections;
using System.Collections.Generic;
using Assignment18;
using UnityEngine;

public class Character
{
    private string name;
    private int health;

    public Character(string Name , int Health){
        this.Name= Name;
        this.Health= Health;
    }

    public string Name
    {
        get { return name; }
        set { name = value; }
    }
    public int Health
    {
        get { return health; }
        set
        {
            if (value > 100)
                health = 100;
            else if (value < 0)
                health = 0;
            else
                health = value;
        }
    }

    public static implicit operator Character(Soldier v)
    {
        throw new NotImplementedException();
    }
}
