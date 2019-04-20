namespace Exercicio1p1
{
    public class Book
    {
        // Variáveis de instância
        private string title;
        private string author;
        private int pages;
        private int wordCount;

        // Variáveis de classe (static)
        private static int totalBooks;

        // Construtor de instâncias
        public Book(string title, string author)
        {
            this.title = title;
            this.author = author;
            totalBooks++;
        }

        // Construtor static (para variáveis static, chamado automaticamente)
        static Book()
        {
            totalBooks = 0;
        }

        // Método getter (static) para obter número de livros instanciados
        public static int GetTotalBooks()
        {
            return totalBooks;
        }

        // Método getter para obter o título do livro
        public string GetTitle()
        {
            return title;
        }

        // Método setter para definir o título do livro
        public void SetTitle(string title)
        {
            if (title != null && title.Length > 0)
                this.title = title;
        }

        // Método getter para obter o nome do autor
        public string GetAuthor()
        {
            return author;
        }

        // Método que atribui número de palavras a partir de string dada como
        // parâmetro
        public void AssignWordCountFromText(string text)
        {
            wordCount = text.Split(' ').Length;
        }

        // Método que devolve comprimento do título do livro
        public int GetTitleLength()
        {
            return title.Length;
        }

    }
}
