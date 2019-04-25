using System;

namespace Aula08
{
    class Program
    {
        static void Main(string[] args)
        {
            PlayerClass pc = new PlayerClass() { Health = 100, Armour = 100};
            PlayerStruct ps = new PlayerStruct() { Health = 100, Armour = 100 };

            KillPlayerClass(pc);
            KillPlayerStruct(ps);

            Console.WriteLine($"Class : {pc.Health}");
            Console.WriteLine($"Struct: {ps.Health}");
        }

        static void KillPlayerClass(PlayerClass pc)
        {
            pc.Health = 0;
        }

        static void KillPlayerStruct(PlayerStruct ps)
        {
            ps.Health = 0;
        }

    }
}
