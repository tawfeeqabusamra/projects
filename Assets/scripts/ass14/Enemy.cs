using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : Character
{
    public Enemy(string Name, int Health) : base(Name, Health)
    {
    }
    public int Attack(Character character , int amount){
        character.Health -= amount;
        return character.Health;
        
    }
}
