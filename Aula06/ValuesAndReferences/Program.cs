using System;

namespace ValuesAndReferences
{
    class Program
    {
        static void Main(string[] args)
        {
            // Variables
            int x0 = 9;
            int[] y0 = new int[] { 2, 3, 4 };
            int x1 = x0;
            int[] y1 = y0;

            // Show x0 and y0 contents
            Console.WriteLine("Original contents:");
            ShowVars(x0, y0);

            // Change x1 and y1
            x1 = 1;
            y1[1] = 1;

            // Check what happened to x0 and y0
            Console.WriteLine("After changing x1 and y1 values:");
            ShowVars(x0, y0);

            // Change y1 again and check what happens to y0
            y1 = new int[] { -5, -4, -3 };
            Console.WriteLine("After changing y1 reference:");
            ShowVars(x0, y0);
        }

        static void ShowVars(int a, int[] b)
        {
            Console.WriteLine($"\tx0 = {a}");
            Console.Write("\ty0 = [ ");
            foreach (int n in b) Console.Write($"{n} ");
            Console.WriteLine("]");
        }
    }
}
