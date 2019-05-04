using System;

namespace Aula07
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create the red and purple colors using object initializer syntax
            Color red = new Color() { Red = 255, Green = 0, Blue = 0 };
            Color purple = new Color() { Red = 255, Green = 0, Blue = 255 };

            // Create two different balls of different colors and sizes.
            Ball bigRed = new Ball(red, 5);
            Ball littlePurple = new Ball(purple, 3);

            // Check individual colors of the purple color
            Console.WriteLine(
                $"Purple = ({purple.Red}, {purple.Green}, {purple.Blue})");

            // Throw the big red ball around a few times.
            bigRed.Throw();
            bigRed.Throw();
            bigRed.Throw();
            Console.WriteLine(bigRed.TimesThrown);

            // Keep throwing it, and make sure that the number of
            // times thrown keeps going up.
            bigRed.Throw();
            bigRed.Throw();
            Console.WriteLine(bigRed.TimesThrown);

            // Throws the little purple ball around.
            littlePurple.Throw();
            littlePurple.Throw();
            Console.WriteLine(littlePurple.TimesThrown);

            // Pop the little purple ball and make sure that the throw
            // count doesn't keep going up if the ball has been popped.
            littlePurple.Pop();
            littlePurple.Throw();
            Console.WriteLine(littlePurple.TimesThrown);
        }
    }
}
