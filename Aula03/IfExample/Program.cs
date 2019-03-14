using System;
using System.Text;

namespace Aula03
{
    class Program
    {
        static void Main(string[] args)
        {
            // Caracteres a usar
            char smile = '\u263A';
            char frown = '\u2639';
            char skull = '\u2620';

            // Nave espacial
            SpaceShip spaceShip = new SpaceShip();

            // Estado da nave
            bool shieldsUp = spaceShip.Shield > 0;
            bool armourOk = spaceShip.Armour > 0;

            // Linha de código necessária para mostrar caracteres Unicode
            Console.OutputEncoding = Encoding.UTF8;

            // Testar o if
            if (shieldsUp && armourOk)
            {
                Console.WriteLine($"You're doing great {smile}");
            }
            else if (shieldsUp ^ armourOk)
            {
                Console.WriteLine($"You don't look so good {frown}");
            }
            else
            {
                Console.WriteLine($"You're dead {skull}");
            }
        }
    }
}
