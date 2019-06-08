using System;

namespace Exercicio7
{
    class Program
    {
        static void Main(string[] args)
        {
            Guarda3<string> g3str = new Guarda3<string>()
                { "Ola", "Tudo bem?", "Adeus" };
            Guarda3<float> g3flt = new Guarda3<float>()
                { 1.2f, -5.9f, 0.9f };

            Console.WriteLine("Conteúdos de g3str:");
            foreach (string s in g3str)
                Console.WriteLine($"\t{s}");

            Console.WriteLine("Conteúdos de g3flt:");
            foreach (float f in g3flt)
                Console.WriteLine($"\t{f}");
        }
    }
}
