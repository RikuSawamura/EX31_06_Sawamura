using System;
using System.Collections.Generic;
using System.Text;

namespace Ex31_hint
{
    internal class Hornet : Animal
    {
        public Hornet(string name, float hp, float power, string animalkinds) : base(name, hp, power, animalkinds)
        {

        }
        public override void Attack(Character destination)
        {
            Console.WriteLine($"{this.name}は{destination.name}に毒針で攻撃！");
            if (destination is Animal)
            {
                Poisn(destination);
            }
            else
            {
                Console.WriteLine($"{destination.name}は{this.power}のダメージ");
                base.Attack(destination);
            }
        }
        public void Poisn(Character destination)
        {
            destination.hp = 0;
            Console.WriteLine($"{destination.name}は毒によって即死した！");
        }
    }
}
