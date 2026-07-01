class InformacaoTecnica
{
    public int TamanhoMB { get; set; }
    public string SistemaOperacional { get; set; }

    public InformacaoTecnica(int tamanhoMB, string sistemaOperacional)
    {
        TamanhoMB = tamanhoMB;
        SistemaOperacional = sistemaOperacional;
    }
}

class ProdutoDigital
{
    public string Nome { get; set;}
    public double Preco { get; set;}
    public InformacaoTecnica InfoTecnica { get; set; }

    public ProdutoDigital(string nome, double preco, InformacaoTecnica infoTecnica)
    {
        Nome = nome;
        Preco = preco;
        InfoTecnica = infoTecnica;
    }

    public void ExibirProduto()
    {
        Console.WriteLine("---- informações tecnicas ----");
        Console.WriteLine($"Produto {Nome}");
        Console.WriteLine($"Preço {Preco:F2}");
        Console.WriteLine($"Tamanho: {InfoTecnica.TamanhoMB} MB");
        Console.WriteLine($"Compativel com: {InfoTecnica.SistemaOperacional}");
    }
}