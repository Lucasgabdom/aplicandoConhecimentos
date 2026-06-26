class Filme
{
    public string Titulo { get; set; }
    public int ClassificacaoIndicativa { get; set; }


    public Filme (string titulo, int classificacaoIndicativa)
    {
        Titulo = titulo;
        ClassificacaoIndicativa = classificacaoIndicativa;
    }

    public bool PodeAssistir(int idade)
    {
        return idade >= ClassificacaoIndicativa;
    }

    public void ExibirResultado (int idadeUsuario)
    {
        if (PodeAssistir(idadeUsuario))
        {
            Console.WriteLine($"Usuário pode assistir o filme {Titulo}.");
        } else {
            Console.WriteLine($"\nO usuário não pode assistir o filme {Titulo} pois é menor que a idade recomendada.");
        }
    }
}