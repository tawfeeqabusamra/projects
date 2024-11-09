using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player1 : Character
{
    public Player1(string Name, int Health) : base(Name, Health)
    {
    }

    public int Heal(int amount)
    {
        Health += amount;
        // Debug.Log(Health);
        return Health;
    }
    
}
