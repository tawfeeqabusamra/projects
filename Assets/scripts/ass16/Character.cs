using System.Collections;
using System.Collections.Generic;
using UnityEngine;



namespace Assignment18
{
    public class Character
    {


        public string name;
        private int health;
        protected Position position;

        public Character(string name, int health, Position position)
        {
            this.name = name;
            this.health = health;
            this.position = position;
        }
        public Character() : this("No name", 100, new Position(0, 0, 0))
        {

        }


        public int Health
        {
            get { return health; }
            // Mathf.Clamp(value, min, max);  أداة تُستخدم لنحديد قيمة متغيرة داخل حدود معينة
            set { Mathf.Clamp(health, 0, 100); }
        }
        public virtual void DisplayInfo()
        {
            Debug.Log($"Character Name: {name}, Health: {health}");
            position.PrintPosition();

        }
        private void ApplyDamage(int damage, Character target)
        {
            target.health -= damage;
        }
        public void Attack(int damage, Character target)
        {
            ApplyDamage(damage, target);

        }
        public void Attack(int damage, Character target, string attackType)
        {
            ApplyDamage(damage, target);
            Debug.Log(attackType);
        }




    }
}



