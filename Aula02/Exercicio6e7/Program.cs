using System;

namespace Aula02
{
    class Program
    {
        static void Main(string[] args)
        {

            // Variaveis do cilindro
            double a, r, v, s;

            // String auxiliar para pedir dados ao utilizador
            string aux;

            // Pedir altura
            Console.Write("Insire altura do cilindro: ");
            aux = Console.ReadLine();

            // Converter string lida contendo altura para double
            a = Convert.ToDouble(aux);

            // Pedir raio
            Console.Write("Insere raio do cilindro: ");
            aux = Console.ReadLine();

            // Converter string lida contendo raio para double
            r = Convert.ToDouble(aux);

            // Determinar volume
            v = Math.PI * Math.Pow(r, 2) * a;

            // Determinar area de superfície
            s = 2 * Math.PI * r * (r + a);

            // Mostrar resultado ao utilizador
            Console.WriteLine($"Volume do cilindro          = {v}");
            Console.WriteLine($"Area superfície do cilindro = {s}");
        }
    }
}
