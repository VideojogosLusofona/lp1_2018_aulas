using System;

namespace Exercicio6
{
    class Program
    {
        static void Main(string[] args)
        {
            Guarda3<string> g3str = new Guarda3<string>();
            Guarda3<float> g3flt = new Guarda3<float>();

            g3str.SetItem(0, "Ola");
            g3str.SetItem(1, "Tudo bem?");
            g3str.SetItem(2, "Adeus");

            g3flt.SetItem(0, 1.2f);
            g3flt.SetItem(1, -5.9f);
            g3flt.SetItem(2, 0.9f);

            Console.WriteLine("Conteúdos de g3str:");
            foreach (string s in g3str)
                Console.WriteLine($"\t{s}");

            Console.WriteLine("Conteúdos de g3flt:");
            foreach (float f in g3flt)
                Console.WriteLine($"\t{f}");
        }
    }
}
