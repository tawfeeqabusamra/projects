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

}
