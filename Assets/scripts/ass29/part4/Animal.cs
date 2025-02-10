using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace an{


public class Animal : MonoBehaviour
{
    public virtual void MakeSound()
    {
        print("Animal sound");
    }
    public void Move()
    {
        print("Animal move");
    }
}
}