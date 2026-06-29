class Produto
{
    public string Nome { get; set; }
    private int QuantidadeEstoque { get; set; }

    public Produto(string nome, int quantidadeEstoque)
    {
        Nome = nome;
        QuantidadeEstoque = quantidadeEstoque;
    }

    public void AdicionarEstoque(int quantidade)
    {
        QuantidadeEstoque += quantidade;
        Console.WriteLine("\n---- Atualizando estoque ----");
        Console.WriteLine($"Estoque de {Nome} atualizado. Agora há {QuantidadeEstoque} unidades.");
    }

    public void RetirarEstoque(int quantidade)
    {
        if (quantidade <= QuantidadeEstoque)
        {
            QuantidadeEstoque -= quantidade;
            Console.WriteLine("\n---- Atualizando estoque ----");
            Console.WriteLine($"Estoque de {Nome} atualizado. Agora resta {QuantidadeEstoque}.");
        } else
        {
            Console.WriteLine($"\nA quantidade solicitada excede o estoque disponível. No estoque restam {QuantidadeEstoque} unidades de {Nome}.");
        }
    }

    public void ExibirEstoque()
    {
        Console.WriteLine("\n---- Informações do Estoque ----");
        Console.WriteLine($"Tem em estoque {QuantidadeEstoque} unidades de {Nome}.");
    }

   
}

