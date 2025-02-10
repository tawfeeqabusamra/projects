using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace an{
public class Cat : Animal , ICanFight
{
    public override void MakeSound()
    {
        Debug.Log("meow");
    }
    public new void Move()
    {
        Debug.Log("Cat runs quickly.");
    } 
    public void Attack(){
        Debug.Log("Cat attacks with claws!");
    }
}
}