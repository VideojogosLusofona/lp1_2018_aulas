using System;

namespace OverrideVsNew
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal a0 = new Animal();
            Animal a1 = new Dog();
            Animal a2 = new Cat();
            Animal a3 = new Elephant();
            Elephant e = new Elephant();

            Console.WriteLine($"a0 (Animal)   : {a0.Sound()}");
            Console.WriteLine($"a1 (Dog)      : {a1.Sound()}");
            Console.WriteLine($"a2 (Cat)      : {a2.Sound()}");
            Console.WriteLine($"a3 (Elephant) : {a3.Sound()}");
            Console.WriteLine($" e (Elephant) : {e.Sound()}");
        }
    }
}
