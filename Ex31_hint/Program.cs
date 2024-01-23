using System;
using System.Security.Cryptography;

namespace Ex31_hint
{
    class Program
    {
        static void Main(string[] args)
        {
            Human human1 = new Human("しむら人", 500, 2, "ヒト");
            Human human2 = new Human("ささっき", 1000, 25, "ヒト");
            Tank tank1 = new Tank("Tiger", 500000, 250);
            tank1.bullet = 10;
            Tank tank2 = new Tank("がんタンク", 10000, 125);
            tank2.bullet = 5;
            Caw caw = new Caw("暴れ牛", 3000, 100, "ウシ");
            Cat cat = new Cat("野良猫", 1500, 75, "ネコ");
            Hornet hornet = new Hornet("蜂", 200, 20, "ハチ");
            Character[] characters = { human1, human2, tank1, tank2, caw, cat, hornet };
            Random rand = new Random();
            int r = rand.Next(characters.Length);
            for (var i = 0; i < characters.Length; i++)
            {
                if (characters[i] != characters[r])
                {
                    characters[i].Attack(characters[r]);
                }
                if (characters[r].hp <= 0)
                {
                    Console.WriteLine("__戦闘終了__");
                    break;
                }
            }
        }
    }
}
