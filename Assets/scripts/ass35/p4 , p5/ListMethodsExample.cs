using System;
using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using Unity.VisualScripting;
using UnityEngine;

public class ListMethodsExample : MonoBehaviour
{

    void Start()
    {
        List<int> numbers = new List<int> { 3, 1, 4, 1, 5, 9 };
        Func<int, int, int> sort = (int x, int y) => y.CompareTo(x);
        numbers.Sort((int x, int y) => y.CompareTo(x));
        string a = string.Join(",", numbers);
        Debug.Log(a);
        // **********************
        // part 5
        List<int> numbers2 = new List<int> { 3, 1, 4, 1, 5, 9, 2, 6 };
        List<int> filteredNumbers = numbers2.FindAll(x => (x % 2) == 0);
        string b = string.Join(",", filteredNumbers);
        Debug.Log(b);


    }

    void Update()
    {

    }
}
