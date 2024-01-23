using System;
using System.Collections.Generic;
using System.Text;

namespace Ex31_hint
{
    internal class Animal : Character
    {
        string animalkinds;
        public Animal(string name, float hp, float power, string animalkinds) : base(name, hp, power)
        {
            this.animalkinds = animalkinds;
        }
    }
}
