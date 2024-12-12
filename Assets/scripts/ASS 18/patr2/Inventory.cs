using System.Collections.Generic;
using UnityEngine;
public class Inventory
{
    public List<string> names = new List<string>();
    public void AddItem(string item)
    {
        names.Add(item);
    }
    public void ShowItems()
    {
        foreach (string i in names)
        {
            Debug.Log(i);
        }
    }
     public static Inventory operator +(Inventory inv1, Inventory inv2)
    {
        Inventory combinedInventory = new Inventory();

        
        foreach (var item in inv1.names)
        {
            combinedInventory.AddItem(item);
        }

        
        foreach (var item in inv2.names)
        {
            combinedInventory.AddItem(item);
        }

        return combinedInventory;
    }

}