using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace an
{

    public class TypeManagementScript : MonoBehaviour
    {
        // Start is called before the first frame update
        void Start()
        {
            Cat cat = new Cat();
            Animal animal = cat;
            animal.MakeSound();
            animal.Move();


            Cat down = animal as Cat;
            down.MakeSound();
            down.Move();
        }
        List<ICanFight> fighters = new List<ICanFight> { new Cat(), new Warrior() };
        // foreach (ICanFight item in fighters)
        // {
            
        // }


    }

        
    }


