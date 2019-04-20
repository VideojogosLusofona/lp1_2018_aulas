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
            Book[] books;
            uint numBooks;

            // Pedir ao utilizador nº de livros
            Console.Write("Quantos livros? ");
            numBooks = Convert.ToUInt32(Console.ReadLine());

            // Agora que sabemos o número de livros, instanciar um array que
            // seja capaz de os conter todos
            books = new Book[numBooks];

            // Para cada livro...
            for (int i = 0; i < numBooks; i++)
            {
                // Declaração de variáveis
                string title, author;

                // Pedir ao utilizador título
                Console.Write($"Título do livro {i + 1}? ");
                title = Console.ReadLine();

                // Pedir ao utilizador autor
                Console.Write($"Autor do livro {i + 1}? ");
                author = Console.ReadLine();

                // Instanciar livro e guarda-lo num array de livros
                books[i] = new Book(title, author);
            }

            // Separador
            Console.WriteLine("\n----------------------\n");

            // Para cada livro...
            foreach (Book b in books)
            {
                // Imprimir título, respetivo comprimento e nome do autor
                Console.WriteLine($"\"{b.GetTitle()}\" ({b.GetTitleLength()} "
                    + $"chars) by {b.GetAuthor()}");
            }

            // Separador
            Console.WriteLine("\n----------------------\n");

            // Total de livros instanciados bate certo com o número pedido pelo
            // utilizador?
            Console.WriteLine($"Utilizador pediu {numBooks} livros");
            Console.WriteLine("Na prática foram instanciados "
                + $"{Book.GetTotalBooks()} livros");
            if (numBooks == Book.GetTotalBooks())
                Console.WriteLine("-> Bate certo!");
            else
                Console.WriteLine("-> Alguma coisa não está bem!");

            // Separador
            Console.WriteLine("\n----------------------\n");
        }
    }
}
