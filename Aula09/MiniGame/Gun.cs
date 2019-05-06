using System;

namespace Aula09
{
    public class Gun : Weapon
    {
        public int Ammo { get; private set; }

        public Gun(float power, int ammo) : base(power)
        {
            Ammo = ammo;
        }

        public void FireGun()
        {
            Ammo--;
            Console.WriteLine(
                $"\tFiring gun with power={power}, {Ammo} bullets left");
        }
    }
}
