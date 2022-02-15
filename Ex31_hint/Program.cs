using System;

namespace Ex31_hint
{
    class Program
    {
        static void Main(string[] args)
        {
            Character character1 = new Character("しむら人", 500, 2, true);
            Character character2 = new Character("ささっき", 1000, 25, false);
            Tank tank1 = new Tank("Tiger", 500000, 250, false);
            tank1.bullet = 10;
            Tank tank2 = new Tank("がんタンク", 10000, 125, false);
            tank2.bullet = 5;

            Cow cow = new Cow("牛",5000,50 ,true);

            Cat cat = new Cat("ニャース", 400, 40,true);

            Honet honet = new Honet("スピアー", 650, 15, true);

            Character[] characters = { character1, character2, tank1, tank2, cow, cat, honet};
            for(var i = 1; i < characters.Length; i++)
            {
                characters[i].Attack(character1);
                characters[i].Attack(character2);
            }
        }
    }
}
