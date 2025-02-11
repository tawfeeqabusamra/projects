using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class BoxingUnboxing : MonoBehaviour
{
    void Start()
    {
        int health = 100;
        Debug.Log("Original int value: " + health);

       
        object boxedHealth = health;
        Debug.Log("Boxed value: " + boxedHealth);

        
        int unboxedHealth = (int)boxedHealth;
        unboxedHealth += 50;
        Debug.Log("Unboxed and modified value: " + unboxedHealth);

    }
}