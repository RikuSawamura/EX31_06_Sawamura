using System;
using System.Collections.Generic;
using System.Text;

namespace Ex31_hint
{
    internal class Caw : Animal
    {
        public Caw(string name, float hp, float power, string animalkinds) : base(name, hp, power, animalkinds)
        {

        }
        public override void Attack(Character destination)
        {
            if (hp > 5)
            {

                Console.WriteLine($"{this.name}は{destination.name}に向けて角で攻撃！");
                Console.WriteLine($"{destination.name}はうしろに吹き飛ばされた！");
                Console.WriteLine($"{destination.name}は{this.power}のダメージ");
                base.Attack(destination);
            }
            else
            {
                Console.WriteLine("ミス！");
            }

        }
    }
}
