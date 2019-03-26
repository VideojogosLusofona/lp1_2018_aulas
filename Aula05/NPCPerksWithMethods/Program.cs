using System;

namespace Aula05
{
    class Program
    {
        static void Main(string[] args)
        {
            // Constantes
            const NPCPerks niceCombo = NPCPerks.Combat | NPCPerks.Luck;

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
                // Indicar a que NPC nos estamos a referir
                Console.WriteLine($"NPC No. {i}");

                // Stealth ?
                perksDeCadaNPC[i] |= ReadPerk(NPCPerks.Stealth);

                // Combat ?
                perksDeCadaNPC[i] |= ReadPerk(NPCPerks.Combat);

                // Lockpick ?
                perksDeCadaNPC[i] |= ReadPerk(NPCPerks.Lockpick);

                // Luck ?
                perksDeCadaNPC[i] |= ReadPerk(NPCPerks.Luck);

            }

            // Mostrar características (perks) de cada NPC
            Console.WriteLine();
            for (int i = 0; i < numNPCs; i++)
            {
                // Características do NPC atual
                Console.WriteLine($"NPC {i} : {perksDeCadaNPC[i]}");

                // Mostrar mensagem especial?
                if ((perksDeCadaNPC[i] & niceCombo) == niceCombo)
                {
                    Console.WriteLine("\tYou shall win all fights!");
                }
            }
        }

        // Método que faz a leitura de um dado perk
        static NPCPerks ReadPerk(NPCPerks perk)
        {
            // Variaveis
            string resposta;
            NPCPerks readPerk = 0;

            // Pedir ao user para confirmar perk
            Console.Write(perk + " (s/n)? ");
            resposta = Console.ReadLine();

            // User confirmou perk?
            if (resposta == "s")
            {
                // Confirmar que sim
                readPerk = perk;
            }

            // Retornar possível perk lido
            return readPerk;
        }
    }
}
