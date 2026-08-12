public class Imagem : Midia
{
    public string Resolucao { get; set; }

    public Imagem (string nome, string resolucao) : base(nome)
    {
        Resolucao = resolucao;
    }

    public override void ExibirInformacoes()
    {
        Console.WriteLine($"Imagem: {Nome}, Resolução: {Resolucao}");
    }
}