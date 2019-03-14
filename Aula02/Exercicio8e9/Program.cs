using System;

namespace Aula02
{
    class Program
    {
        static void Main(string[] args)
        {
            // Variáveis auxiliares
            short a;
            float f;

            // Mostrar mínimos e máximos
            Console.WriteLine($"byte vai de {byte.MinValue} " +
                $"até {byte.MaxValue}");
            Console.WriteLine($"sbyte vai de {sbyte.MinValue} " +
                $"até {sbyte.MaxValue}");
            Console.WriteLine($"short vai de {short.MinValue} " +
                $"até {short.MaxValue}");
            Console.WriteLine($"ushort vai de {ushort.MinValue} " +
                $"até {ushort.MaxValue}");
            Console.WriteLine($"int vai de {int.MinValue} " +
                $"até {int.MaxValue}");
            Console.WriteLine($"uint vai de {uint.MinValue} " +
                $"até {uint.MaxValue}");
            Console.WriteLine($"long vai de {long.MinValue} " +
                $"até {long.MaxValue}");
            Console.WriteLine($"ulong vai de {ulong.MinValue} " +
                $"até {ulong.MaxValue}");
            Console.WriteLine($"float vai de {float.MinValue} " +
                $"até {float.MaxValue}");
            Console.WriteLine($"double vai de {double.MinValue} " +
                $"até {double.MaxValue}");
            Console.WriteLine($"decimal vai de {decimal.MinValue} " +
                $"até {decimal.MaxValue}");

            // Overflow
            a = short.MaxValue;
            f = float.MaxValue;
            Console.WriteLine("Overflow");
            Console.WriteLine($"\tEm short: {(short) (a + 1)}");
            Console.WriteLine($"\tEm float (tipo 1): {f * 2}");
            Console.WriteLine($"\tEm float (tipo 2): {f + 1}");

            // Underflow
            f = 10000f;
            Console.WriteLine("Underflow");
            Console.WriteLine("\tValor de f = {0}", f);
            Console.WriteLine("\tValor de f + 0.0001f = {0}", f + 0.0001f);
        }
    }
}
