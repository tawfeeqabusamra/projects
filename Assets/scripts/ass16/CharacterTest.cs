using System.Collections;
using System.Collections.Generic;

using UnityEngine;
namespace Assignment18
{
    public class CharacterTest : MonoBehaviour
    {
        Soldier soldier = new Soldier();
        Officer officer = new Officer("tefo", 100, new Position(0, 0, 0));
        void Start()
        {

            Character[] characters = { soldier, officer };

            foreach (Character character in characters)
            {
                character.DisplayInfo();
            }
            Debug.Log(soldier.Health);
            officer.Attack(40, soldier);
            Debug.Log(Mathf.Clamp(soldier.Health, 0, 100));



        }


    }
}
