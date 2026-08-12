public class Midia
{
    public string Nome { get; set; }

    public Midia (string nome)
    {
        Nome = nome;
    }

    public virtual void ExibirInformacoes()
    {
        Console.WriteLine($"Nome da mídia: {Nome}");
    }
}