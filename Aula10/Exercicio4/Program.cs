using System;

namespace Exercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            // Number of different types of animals
            const int dif = 4;
            // Number of animals to create
            const int n = 10;
            // Array of animals
            Animal[] animals = new Animal[n];
            // Random number generator
            Random rnd = new Random();

            // Create 10 random animals
            for (int i = 0; i < n; i++)
            {
                // Determine which animal to create and create it
                switch (rnd.Next(dif))
                {
                    case 0:
                        animals[i] = new Dog();
                        break;
                    case 1:
                        animals[i] = new Cat();
                        break;
                    case 2:
                        animals[i] = new Bee();
                        break;
                    case 3:
                        animals[i] = new Bat();
                        break;
                }
            }

            // Show info about each animal
            foreach (Animal a in animals)
            {
                // Show info all animals have (name and sound they make)
                Console.Write($"I'm a {a.GetType().Name}, I say {a.Sound()}");
                // If animal is a mammal show number of nipples
                if (a is IMammal)
                    Console.Write(
                        $", I have {(a as IMammal).NumberOfNipples} nipples");
                // If animal can fly show number of wings
                if (a is ICanFly)
                    Console.Write(
                        $", I have {(a as ICanFly).NumberOfWings} wings");
                Console.WriteLine();
            }
        }
    }
}
