using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;

public class BasicsScript : MonoBehaviour
{
    int num = 5;
    string st;
    bool bl;

    void Start()
    {
        bl = (num % 2 == 0) ? true : false;
        if (bl)
        {
            st = $"the {num} is even";
        }
        else
        {
            st = $"the {num} is odd";
        }
        Debug.Log(st);
        Debug.Log(DateTime.Now.Date);
        Debug.Log(DateTime.Now.TimeOfDay);
        Debug.Log(DateTime.Now.DayOfWeek);
    }

    void Update()
    {

    }
}
