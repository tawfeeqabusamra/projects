using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameInventory : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()

    {
        Inventory potions = new Inventory();
        potions.AddItem("Healing Potion");
        potions.AddItem("Strength Potion");
        Inventory elixirs = new Inventory();
        elixirs.AddItem("Elixir");
        elixirs.AddItem("Dark Elixir");
        Inventory combinedInventory = potions + elixirs;
        combinedInventory.ShowItems();

    }

    // Update is called once per frame
    void Update()
    {

    }
}
