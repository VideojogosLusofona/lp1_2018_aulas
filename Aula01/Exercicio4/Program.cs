using System;
using System.Text;

namespace Exercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            // Variáveis inteiras
            sbyte i01 = 1;
            byte i02 = 2;
            short i03 = 3;
            ushort i04 = 4;
            int i05 = 5;
            uint i06 = 6;
            long i07 = 7;
            ulong i08 = 8;

            // Variáveis do tipo char
            char c01 = '\u08a4'; // Caráter arábico
            char c02 = '\u2167'; // 8 em romano (VIII)

            // Variáveis do tipo real
            float r01 = 123.45f;
            double r02 = 2.5e-8; // 2,5 x 10^-8
            decimal r03 = 0.0122342345340987978m;

            // Variáveis do tipo boleano
            bool b01 = true;
            bool b02 = false;

            // Linha de código necessária para mostrar caracteres Unicode
            Console.OutputEncoding = Encoding.UTF8;

            // Mostrar variáveis inteiras
            Console.WriteLine("Variáveis do tipo inteiro:");
            Console.WriteLine("\t" + i01);
            Console.WriteLine("\t" + i02);
            Console.WriteLine("\t" + i03);
            Console.WriteLine("\t" + i04);
            Console.WriteLine("\t" + i05);
            Console.WriteLine("\t" + i06);
            Console.WriteLine("\t" + i07);
            Console.WriteLine("\t" + i08);

            // Mostrar variáveis do tipo char
            Console.WriteLine("Variáveis do tipo char:");
            Console.WriteLine("\t" + c01);
            Console.WriteLine("\t" + c02);

            // Mostrar variáveis do tipo real
            Console.WriteLine("Variáveis do tipo real:");
            Console.WriteLine("\t" + r01);
            Console.WriteLine("\t" + r02);
            Console.WriteLine("\t" + r03);

            // Mostrar variáveis do tipo boleano
            Console.WriteLine("Variáveis do tipo bool:");
            Console.WriteLine("\t" + b01);
            Console.WriteLine("\t" + b02);

        }
    }
}
