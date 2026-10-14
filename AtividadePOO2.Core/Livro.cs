namespace AtividadePOO2.Core;

public class Livro
{
    public DateTime DataLancamento { get; set; }
    public string Titulo { get; set; }
    public string Autor { get; set; }
    public string Genero { get; set; }
    public int Paginas { get; set; }

    public Livro(DateTime dataLancamento, string titulo, string autor, string genero, int paginas)
    {
        ValidarDataLancamento(dataLancamento);
        ValidarTitulo(titulo);
        ValidarAutor(autor);
        ValidarGenero(genero);
        ValidarPaginas(paginas);
    }

    private void ValidarPaginas(int paginas)
    {
        if (paginas <= 0)
            throw new Exception("O número de páginas deve ser maior que zero!");
    }

    private void ValidarTitulo(string titulo)
    {
        if (string.IsNullOrWhiteSpace(titulo))
            throw new Exception("O titulo do livro não pode ser nulo ou vazio!");

        if (titulo.Length < 3)
            throw new Exception("O título do livro precisa ter pelo menos 3 caracteres!");
    }

    private void ValidarGenero(string? genero)
    {
        if (string.IsNullOrWhiteSpace(genero))
            throw new Exception("O genero do livro não pode ser nulo ou vazio!");

        if (genero.Length < 3)
            throw new Exception("O género do livro precisa ter pelo menos 3 caracteres!");
    }

    private void ValidarAutor(string? autor)
    {
        if (string.IsNullOrWhiteSpace(autor))
            throw new Exception("O autor do livro nao pode ser nulo ou vazio");

        if (autor.Length < 3)
            throw new Exception("O nome do autor precisa ter pelo menos 3 caracteres!");
    }


    private void ValidarDataLancamento(DateTime dataLancamento)
    {
        {
            if (dataLancamento == default)
                throw new Exception("A data do livro não pode ser vazia!");

            if (dataLancamento > DateTime.Today)
                throw new Exception("A data do livro não pode ser futura!");
        }
    }
    private void Validarpreco(int preco)
    {
        if (preco <= 0)
            throw new Exception("O preço do livro deve ser maior que zero!");
    }
    
}