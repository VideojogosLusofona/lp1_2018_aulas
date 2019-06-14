using System;

namespace Exercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            // Variáveis
            SuperList sl = new SuperList() { -1.5, 2.2, 1.9, -9.5, 4.8, 2.33 };
            double min, max;
            SuperList.MinMax mm;
            Tuple<double, double> t;

            // Usar primeiro método
            sl.GetMinMax1(out min, out max);
            Console.WriteLine($"1. Min = {min}, Max = {max}");

            // Usar segundo método
            mm = sl.GetMinMax2();
            Console.WriteLine($"2. Min = {mm.Min}, Max = {mm.Max}");

            // Usar terceiro método
            t = sl.GetMinMax3();
            Console.WriteLine($"3. Min = {t.Item1}, Max = {t.Item2}");
        }
    }
}
