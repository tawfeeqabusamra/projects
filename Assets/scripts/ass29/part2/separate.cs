using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
namespace ass29
{

    public class separate : MonoBehaviour
    {

        void Start()
        {

            CustomObject obj1 = new CustomObject(1, "Ex");
            CustomObject obj2 = new CustomObject(1, "Ex");

            print(obj1.ToString());
            print("Are objects equal? " + (obj1 == obj2));
            print("Are objects not equal? " + (obj1 != obj2));

        }



    }
}