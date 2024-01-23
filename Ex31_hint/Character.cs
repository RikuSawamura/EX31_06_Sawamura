using System;
using System.Collections.Generic;
using System.Text;

namespace Ex31_hint
{
    class Character
    {
        readonly public string name;
        public float hp;
        protected float power;
        public Character(string name, float hp, float power)
        {
            this.name = name;
            this.hp = hp;
            this.power = power;
        }
        public virtual void Attack(Character destination)
        {
            destination.hp -= this.power;
            if (destination.hp > 0)
            {
                Console.WriteLine($"{destination.name}の残りのHPは{destination.hp}");
                Console.WriteLine("__________");
            }
            else
            {
                Console.WriteLine($"{destination.name}はたおれた");
            }
        }
    }
}
