using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuiltInDelegatesExample : MonoBehaviour
{

    void Start()
    {
        Action logmessage = () => Debug.Log("action");
        logmessage();
        Func<int, int> sq = (int a) => a * a;
        Debug.Log($"Square: {sq(5)}");
        Predicate<int> isEven = (int i) => i % 2 == 0;
        Debug.Log($"Is 4 even? {isEven(4)}");
    }
}
