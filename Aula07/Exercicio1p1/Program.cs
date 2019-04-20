using System;

namespace Exercicio1p1
{
    // Não fazemos nada de especial aqui, apenas instanciamos um livro e
    // invocamos alguns métodos
    class Program
    {
        static void Main(string[] args)
        {
            // Declaração de variáveis
            Book livro = new Book(
                "The Reality Dysfunction", "Peter F. Hamilton");

            // Imprimir título do livro
            Console.WriteLine($"Título: {livro.GetTitle()}");

            // Passar texto do livro de modo a que o mesmo conte as palavras
            // desse texto
            livro.AssignWordCountFromText("Space outside the attack cruiser "
                + "Beezling tore open in five places, For a moment anyone "
                + "looking into the expanding rents would have received a true "
                + "glimpse into empty infinity. The pseudofabric structure of "
                + "the wormholes was a photonic dead zone, a darkness so "
                + "profound it seemed to be spilling out to contaminate the "
                + "real universe. Then ships were suddenly streaking up out "
                + "of the gaping termini, accelerating away at six gees, "
                + "twisting round on interception trajectories. They were "
                + "different from the spherical Garissan naval craft which "
                + "they had tracked between the stars, graceful, streamlined "
                + "teardrop shapes. Larger and dangerously powerful. Alive.");
        }
    }
}
