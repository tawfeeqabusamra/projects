using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class Utilities
{
    public static int Add(params int[] numbers)
    {
        int total = 0;
        foreach (int i in numbers)
        {
            total += i;

        }
        return total;
    }
    public static string RepeatString(this string a,int z )
    {
        string str="";
        for (int i = 0; i < z; i++)
        {
          str+=  a;
        }
        return str;
    }
}
