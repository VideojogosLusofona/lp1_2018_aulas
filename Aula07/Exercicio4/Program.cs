using System;

// Fully documented version of this exercise available at
// http://starboundsoftware.com/books/c-sharp/try-it-out/designing-and-building-classes
namespace Aula06
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create the red and purple colors
            Color red = new Color(255, 0, 0);
            Color purple = new Color(255, 0, 255);

            // Create two different balls of different colors and sizes.
            Ball bigRed = new Ball(red, 5);
            Ball littlePurple = new Ball(purple, 3);

            // Check individual colors of the purple color
            Console.WriteLine(
                $"Purple = ({purple.GetRed()}, {purple.GetGreen()}, {purple.GetBlue()})");

            // Throw the big red ball around a few times.
            bigRed.Throw();
            bigRed.Throw();
            bigRed.Throw();
            Console.WriteLine(bigRed.GetTimesThrown());

            // Keep throwing it, and make sure that the number of
            // times thrown keeps going up.
            bigRed.Throw();
            bigRed.Throw();
            Console.WriteLine(bigRed.GetTimesThrown());

            // Throws the little purple ball around.
            littlePurple.Throw();
            littlePurple.Throw();
            Console.WriteLine(littlePurple.GetTimesThrown());

            // Pop the little purple ball and make sure that the throw
            // count doesn't keep going up if the ball has been popped.
            littlePurple.Pop();
            littlePurple.Throw();
            Console.WriteLine(littlePurple.GetTimesThrown());
        }
    }
}
