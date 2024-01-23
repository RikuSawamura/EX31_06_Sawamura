using System;
using System.Collections.Generic;
using System.Text;

namespace Ex31_hint
{
    internal class Cat : Animal
    {
        public Cat(string name, float hp, float power, string animalkinds) : base(name, hp, power, animalkinds)
        {

        }
        public override void Attack(Character destination)
        {
            Console.WriteLine($"{this.name}は{destination.name}に向けてひっかき攻撃！");
            Console.WriteLine($"{destination.name}は{this.power}のダメージ");
            base.Attack(destination);
        }
    }
}
