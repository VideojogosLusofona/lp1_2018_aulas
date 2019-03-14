using System;
using System.Text;

namespace Aula02
{
    class Program
    {
        static void Main(string[] args)
        {
            // Variáveis auxiliares
            int n = 2;
            double xx = 0.12345;
            int ii = 18;

            // Strings normais
            string s01 = "Sou uma string";
            string s02 = "Contenho carateres Unicode \u263A \u2639";

            // String verbatim
            string s03 = @"Sou \n string \t verbatim \n \u1234 \u9876";

            // Strings criadas com concatenação
            string s04 = "Dois árabe é " + n + ", dois romano é " + '\u2161';
            string s05 = "Concatenação : Valor de n é " + n;
            string s06 = "Concatenação : Quanto é n + 3? Resposta: " + (n + 3);

            // Strings criadas por interpolação
            string s07 = $"Interpolação : Valor de n é {n}";
            string s08 = $"Interpolação : Quanto é n + 3? Resposta: {n + 3}";

            // Strings criadas com String.Format()
            string s09 = String.Format("String.Format: Valor de n é {0}", n);
            string s10 = String.Format("String.Format: Quanto é n + 3? " +
                "Resposta: {0}", n + 3);

            // Linha de código necessária para mostrar caracteres Unicode
            Console.OutputEncoding = Encoding.UTF8;

            // Imprimir variáveis do tipo string
            Console.WriteLine(s01);
            Console.WriteLine(s02);
            Console.WriteLine(s03);
            Console.WriteLine(s04);
            Console.WriteLine(s05);
            Console.WriteLine(s06);
            Console.WriteLine(s07);
            Console.WriteLine(s08);
            Console.WriteLine(s09);
            Console.WriteLine(s10);

            // Imprimir strings diretamente (estilo printf)
            Console.WriteLine("Diretamente  : Valor de n é {0}", n);
            Console.WriteLine("Diretamente  : Quanto é n + 3? Resposta: {0}",
                n + 3);

            // Imprimir variável xx como número real com duas casas decimais
            // usando interpolação (podiamos ter usado o estilo printf)
            Console.WriteLine($"{xx:f2}");

            // Imprimir variável xx como percentagem com uma casa decimal
            // usando interpolação (podiamos ter usado o estilo printf)
            Console.WriteLine($"{xx:p1}");

            // Imprimir variável ii como hexadecimal usando estilo printf
            // (podiamos ter usado interpolação)
            Console.WriteLine("{0:x}", ii);

            // Imprimir variável ii como moeda usando estilo printf
            // (podiamos ter usado interpolação)
            Console.WriteLine("{0:c}", ii);

        }
    }
}
