using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character 
{
    private string Name;
    private int Health;
    
    
    public Character(string Name , int Health){
        this.Name= Name;
        this.Health= Health;
    }

    public string name
    {
        get;
        set;
    }
    public int health
    {
        get { return Health; }
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

}
