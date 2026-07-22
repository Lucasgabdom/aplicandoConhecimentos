public class Pessoa
{
    public string Nome { get; set; }
    public int Idade { get; set; }
    public Pessoa(string nome, int idade)
    {
        Nome = nome;
        Idade = idade;
    }
}

public class Passageiro : Pessoa
{
    public int QuantidadeBilhete { get; set; }

    public Passageiro (string nome, int idade, int quantidadeBilhete) : base(nome, idade)
    {
        QuantidadeBilhete = quantidadeBilhete;
    }

    public void ExibirInformacoes()
    {
        Console.WriteLine($"Nome: {Nome}, Idade: {Idade}, Quantidade de Bilhetes: {QuantidadeBilhete}");
    }
}

class Program
{
    static void Main(string[] args)
    {
       Passageiro p1 = new Passageiro ("Lucas", 25, 3);
       Passageiro p2 = new Passageiro("Daniel", 30, 5);

        p1.ExibirInformacoes();
        p2.ExibirInformacoes();
    }
}

