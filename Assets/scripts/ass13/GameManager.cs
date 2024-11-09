using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    
    void Start()
    {
        Player tefo = new Player();
        Player ali = new Player();

        
        tefo.InitializePlayer("tefo", 50);
        ali.InitializePlayer("ali", 75);

       
        tefo.Heal(10);  
        ali.Heal(true);

       
        Player.ShowPlayerCount();
    }

}
