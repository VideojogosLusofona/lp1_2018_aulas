using System;

namespace Aula03
{

    public class SpaceShip
    {

        const int maxShield = 3;
        const int maxArmour = 2;

        private Random rng;

        public SpaceShip()
        {
            rng = new Random();
        }

        public int Shield
        {
            get
            {
                return rng.Next(0, maxShield);
            }
        }

        public int Armour
        {
            get
            {
                return rng.Next(0, maxArmour);
            }
        }
    }
}