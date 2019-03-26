using System;

namespace Aula05
{
    class FamousQuotes
    {
        static void Main(string[] args)
        {
            Console.WriteLine("You talking to me?");
            MyPrecious();
            Console.WriteLine("Dodge this");
            Hasta();
        }

        static void Hasta()
        {
            TheMoney();
            Console.WriteLine("Hasta la vista, baby.");
            MyPrecious();
        }

        static void TheMoney()
        {
            Console.WriteLine("Show me the money!");
        }

        static void MyPrecious()
        {
            TheMoney();
            Console.WriteLine("My precious.");
        }
    }
}
