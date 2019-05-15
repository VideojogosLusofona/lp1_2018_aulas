using System;

namespace Polimorfismo
{
    public class Dog : Animal
    {
        public override string Sound()
        {
            return base.Sound() + "Woof!";
        }
    }
}
