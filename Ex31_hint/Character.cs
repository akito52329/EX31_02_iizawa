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
        public bool animal;
        public Character(string name,float hp,float power, bool animal)
        {
            this.name = name;
            this.hp = hp;
            this.power = power;
            this.animal = animal;
        }

        public virtual void Attack(Character destination)
        {
            Console.WriteLine($"{this.name}は{destination.name}をぶんなぐった！");
            Console.WriteLine($"{destination.name}は{this.power}のダメージ");
            destination.hp -= this.power;
            Console.WriteLine($"{destination.name}の残りのHPは{destination.hp}");
        }
    }
}
