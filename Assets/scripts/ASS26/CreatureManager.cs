using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Assignment26
{
    public class CreatureManager : MonoBehaviour
    {

        void Start()
        {
            List<Creature> list = new List<Creature>();
            Kangaroo kangaroo = new Kangaroo();
            list.Add(kangaroo);
            Duck duck = new Duck();
            list.Add(duck);
            List<IRunnable> list2 = new List<IRunnable>();
            List<IJumpable> list3 = new List<IJumpable>();
            List<ISwimmable> list4 = new List<ISwimmable>();
            list2.Add(kangaroo);
            list3.Add(kangaroo);
            list2.Add(duck);
            list4.Add(duck);
            duck.Speak();
            kangaroo.Speak();
            foreach (IRunnable i in list2)
            {
                i.Run();
            }
            foreach (IJumpable i in list3)
            {
                i.Jump();
            }
            foreach (ISwimmable i in list4)
            {
                i.Swim();
            }


        }


        void Update()
        {

        }
    }

}
