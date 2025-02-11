using System.Collections;
using System.Collections.Generic;
using UnityEngine;

    
 
public class MulticastDelegateExample : MonoBehaviour
{
    
    delegate void MathOperation(int number);

    void DoubleNumber(int number) => Debug.Log($"Double: {number * 2}");
    void SquareNumber(int number) => Debug.Log($"Square: {number * number}");
    void CubeNumber(int number) => Debug.Log($"Cube: {number * number * number}");
    void Start()
    {
        
        MathOperation operation=null;

       
        operation += DoubleNumber;
        operation += SquareNumber;
        operation += CubeNumber;

        
        if (operation != null)
        {
            operation(5);
        }
    }

    
    
}
