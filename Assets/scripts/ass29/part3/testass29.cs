using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test : MonoBehaviour
{

    void Start()
    {
        Debug.Log(Utilities.Add(1, 3, 4, 5, 6, 88));
        string rep = "hiii".RepeatString(3);
        Debug.Log(rep);
    }

}
