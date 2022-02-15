using System;
using System.Collections.Generic;
using System.Text;

namespace Ex31_hint
{
    class Cat: Character
    {
        public int bullet = 0;
        public Cat(string name, float hp, float power ,bool animal) : base(name, hp, power, animal) { }
        public override void Attack(Character destination)
        {
            Console.WriteLine($"{this.name}は{destination.name}にひっかくこうげき！");
            Console.WriteLine($"{destination.name}は{this.power}のダメージをうけた");
            destination.hp -= this.power;
            Console.WriteLine($"{destination.name}の残りのHPは{destination.hp}");
        }
    }
}