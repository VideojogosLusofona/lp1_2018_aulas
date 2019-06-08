using System;

namespace Exercicio5
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
            Console.WriteLine($"\t{g3str.GetItem(0)}");
            Console.WriteLine($"\t{g3str.GetItem(1)}");
            Console.WriteLine($"\t{g3str.GetItem(2)}");

            Console.WriteLine("Conteúdos de g3flt:");
            Console.WriteLine($"\t{g3flt.GetItem(0)}");
            Console.WriteLine($"\t{g3flt.GetItem(1)}");
            Console.WriteLine($"\t{g3flt.GetItem(2)}");
        }
    }
}
