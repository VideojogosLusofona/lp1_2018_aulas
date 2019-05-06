using System;

namespace Aula09
{
    public class Sword : Weapon
    {
        public float BladeLength { get; private set; }

        public Sword(float power, float bladeLength) : base(power)
        {
            BladeLength = bladeLength;
        }

        public void AttackWithSword()
        {
            Console.WriteLine($"\tUsing a sword with blade length={BladeLength}" 
                + $" and power={power} to attack!");
        }
    }
}
