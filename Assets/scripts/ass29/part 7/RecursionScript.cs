using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEngine;


public class RecursionScript : MonoBehaviour
{
    void Start()
    {
        int n1 = 10;
        int n2 = 30;

        Debug.Log($"Fibonacci Recursive ({n1}): {FibonacciRecursive(n1)}");
        Debug.Log($"Fibonacci Recursive ({n2}): {FibonacciRecursive(n2)}");

        Debug.Log($"Fibonacci Iterative ({n1}): {FibonacciIterative(n1)}");
        Debug.Log($"Fibonacci Iterative ({n2}): {FibonacciIterative(n2)}");



    }

    int FibonacciRecursive(int n)
    {
        if (n <= 1) return n;
        return FibonacciRecursive(n - 1) + FibonacciRecursive(n - 2);
    }

    int FibonacciIterative(int n)
    {
        if (n <= 1) return n;

        int a = 0, b = 1, temp;
        for (int i = 2; i <= n; i++)
        {
            temp = a + b;
            a = b;
            b = temp;
        }
        return b;
    }
}


