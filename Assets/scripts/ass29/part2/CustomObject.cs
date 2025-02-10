using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
namespace ass29
{


    public class CustomObject
    {
        int ID;
        string name;
        public CustomObject(int ID, string name)
        {
            this.ID = ID;
            this.name = name;
        }
        public override string ToString()
        {
            return $"Object [ID: {ID}, Name: {name}]";
        }
        public override bool Equals(object obj)
        {
            if (obj is CustomObject oth)
            {

                return this.ID == oth.ID && this.name == oth.name;
            }
            else return false;
        }
        public static bool operator ==(CustomObject obj1, CustomObject obj2)
        {
            if (ReferenceEquals(obj1, obj2)) return true;
            if (obj1 is null || obj2 is null) return false;
            return obj1.ID == obj2.ID && obj1.name == obj2.name;
        }

        public static bool operator !=(CustomObject obj1, CustomObject obj2)
        {
            return !(obj1 == obj2);
        }
    }
}