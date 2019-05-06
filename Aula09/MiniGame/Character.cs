using System;

namespace Aula09
{
    public class Character
    {
        protected Weapon[] weapons;
        public string Name { get; protected set; }

        public void Fight()
        {
            Console.WriteLine("I'm a " + GetType() + " named " + Name
                + " and I have " + weapons.Length + " weapons");

            foreach (Weapon w in weapons)
            {
                if (w is Gun)
                {
                    (w as Gun).FireGun();
                }
                else if (w is Sword)
                {
                    (w as Sword).AttackWithSword();
                }
                else
                {
                    Console.WriteLine("Unknown weapon!");
                }
            }
        }
    }
}
