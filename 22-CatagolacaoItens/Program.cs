using System.Security.Cryptography.X509Certificates;

public class ItemDigital
{
    public string Nome { get; set; }

    public ItemDigital (string nome)
    {
        Nome = nome;
    }

}

class Pergaminho : ItemDigital
{
    string Conteudo { get; set; }

    public Pergaminho (string nome, string conteudo) : base(nome)
    {
        Conteudo = conteudo;
    }

    public void ExibirInformacoes()
    {
        Console.WriteLine("----- Exibindo Informações do Pergaminho -----");
        Console.WriteLine($"Titulo: {Nome}");
        Console.WriteLine($"Descrição: {Conteudo}");


    }
}

class Program
{
    static void Main(string[] args)
    {
        Pergaminho pergaminhoAntigo  = new Pergaminho("Pergaminho Antigo", "Este pergaminho contém informações valiosas sobre a história da civilização antiga.");
        
        pergaminhoAntigo.ExibirInformacoes();
    }
}