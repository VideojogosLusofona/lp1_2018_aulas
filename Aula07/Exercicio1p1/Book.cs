namespace Exercicio1p1
{
    public class Book
    {
        // Variáveis de instância
        private string title;
        private string author;
        private int pages;
        private int wordCount;

        // Construtor
        public Book(string title, string author)
        {
            this.title = title;
            this.author = author;
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
