using System;
using System.Collections.Generic;
using System.Text;

namespace Ex31_hint
{
    class Cow : Character
    {
        private int attackHp = 5;

        public Cow(string name, float hp, float power, bool animal) : base(name, hp, power, animal) { }
        public override void Attack(Character destination)
        {
            float recoilDamege = this.power / 2;
            if (hp > attackHp)
            {
                Console.WriteLine($"{this.name}は{destination.name}に角で突くこうげきをした！");
                Console.WriteLine($"{destination.name}はうしろに吹っ飛んだ！");
                Console.WriteLine($"{destination.name}は{this.power}のダメージ");
                destination.hp -= this.power;
                Console.WriteLine($"{destination.name}の残りのHPは{destination.hp}");
                this.hp -= recoilDamege;
                Console.WriteLine($"{this.name}は{recoilDamege}の反動を受けた");
                Console.WriteLine($"{this.name}の残りのHPは{this.hp}");
            }
            else
            {
                Console.WriteLine($"{base.name}はHPが少なくてこうげきができない！");
            }
        }
    }
}