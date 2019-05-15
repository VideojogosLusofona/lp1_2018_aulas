using System;

namespace OverrideVsNew
{
    public class Cat : Animal
    {
        public override string Sound()
        {
            return base.Sound() + "Miau";
        }
    }
}
