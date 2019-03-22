using System;

namespace Aula04
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declaração de variáveis
            int numNPCs;
            string numNPCsString;
            NPCPerks[] perksDeCadaNPC;

            // Pedir número de NPCs
            Console.Write("Indica o número de NPCs: ");
            numNPCsString = Console.ReadLine();
            numNPCs = Convert.ToInt32(numNPCsString);

            // Inicializar array de perks
            perksDeCadaNPC = new NPCPerks[numNPCs];

            // Pedir perks para cada NPC
            for (int i = 0; i < numNPCs; i++)
            {
                // Declaração de variáveis locais ao for
                string resposta;

                // Indicar a que NPC nos estamos a referir
                Console.WriteLine($"NPC No. {i}");

                // Stealth ?
                Console.Write("\tStealth? (s/n) ");
                resposta = Console.ReadLine();
                if (resposta[0] == 's')
                {
                    perksDeCadaNPC[i] |= NPCPerks.Stealth;
                }

                // Combat ?
                Console.Write("\tCombat? (s/n) ");
                resposta = Console.ReadLine();
                if (resposta[0] == 's')
                {
                    perksDeCadaNPC[i] |= NPCPerks.Combat;
                }

                // Stealth ?
                Console.Write("\tLockpick? (s/n) ");
                resposta = Console.ReadLine();
                if (resposta[0] == 's')
                {
                    perksDeCadaNPC[i] |= NPCPerks.Lockpick;
                }

                // Stealth ?
                Console.Write("\tLuck? (s/n) ");
                resposta = Console.ReadLine();
                if (resposta[0] == 's')
                {
                    perksDeCadaNPC[i] |= NPCPerks.Luck;
                }
            }

            // Mostrar características (perks) de cada NPC
            Console.WriteLine();
            for (int i = 0; i < numNPCs; i++)
            {
                // Características do NPC atual
                Console.WriteLine($"NPC {i} : {perksDeCadaNPC[i]}");

                // Mostrar mensagem especial?
                if ((perksDeCadaNPC[i] & NPCPerks.Combat) == NPCPerks.Combat
                    &&
                    (perksDeCadaNPC[i] & NPCPerks.Luck) == NPCPerks.Luck)
                {
                    Console.WriteLine("\tYou shall win all fights!");
                }
            }
        }
    }
}
