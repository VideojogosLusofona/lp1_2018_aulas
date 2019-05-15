using System;

namespace OverrideVsNew
{
    public class Dog : Animal
    {
        public override string Sound()
        {
            return base.Sound() + "Woof!";
        }
    }
}
