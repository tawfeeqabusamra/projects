using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player
{
  
    public string playerName;
    public int health;
    public static int playerCount = 0;
    private string v1;
    private int v2;

    public Player(string v1, int v2)
    {
        this.v1 = v1;
        this.v2 = v2;
    }

    public Player()
    {
    }

    public void InitializePlayer(string name, int initialHealth)
    {
        playerName = name;
        health = initialHealth;
        playerCount++;
    }

 
    public void Heal(int amount)
    {
        health += amount;
        Debug.Log(health);
    }

        public void Heal(bool fullRestore)
    {
        if (fullRestore)
        {
            health = 100; 
            Debug.Log(health);
        }
    }

    
    public static void ShowPlayerCount()
    {
        Debug.Log(playerCount);
    }
}
