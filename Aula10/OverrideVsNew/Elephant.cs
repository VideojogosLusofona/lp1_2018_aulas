using System;

namespace OverrideVsNew
{
    public class Elephant : Animal
    {
        public new string Sound()
        {
            // Som de um elefante a andar
            return "Stomp, Stomp, Stomp";
        }
    }
}
