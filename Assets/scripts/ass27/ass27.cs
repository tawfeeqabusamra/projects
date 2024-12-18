using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.UIElements;

public class ass27 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int a = 1;
        int b = 2;
        int num = 3;
        add(a);
        Debug.Log("a now = " + a);
        addref(ref b);
        Debug.Log("b now = " + b);
        addout(out num);
        Debug.Log("num now = " + num);

    }
    public void add(int a2)
    {
        a2 += 10;
        Debug.Log(a2);
    }
    public void addref(ref int b2)
    {
        b2 += 10;
        Debug.Log(b2);
    }
    public void addout(out int num)
    {
        num = 3;
        num += 10;
        Debug.Log(num);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
