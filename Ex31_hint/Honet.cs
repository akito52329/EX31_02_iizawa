using System;
using System.Collections.Generic;
using System.Text;

namespace Ex31_hint
{
    class Honet: Character
    {
        public Honet(string name, float hp, float power ,bool animal) : base(name, hp, power, animal) { }
        public override void Attack(Character destination)
        {
            if (destination.animal)
            {
                Console.WriteLine($"{this.name}は{destination.name}にどくばりのこうげき！");
                Console.WriteLine($"{destination.name}は毒状態になった！");
                Console.WriteLine($"{destination.name}は{destination.hp}のダメージ");
                destination.hp -= destination.hp;
                Console.WriteLine($"{destination.name}は目の前が真っ白になった");
            }
            else
            {
                Console.WriteLine($"{destination.name}にはこうかがない！");
            }
        }
    }
}