using System.Net.Http.Headers;
using System.Security.Cryptography.X509Certificates;

internal class Estudante
{
    public string Nome { get; set; }
    public double Nota1 { get; set; }
    public double Nota2 { get; set; }

    public Estudante (string nome)
    {
        Nome = nome;
    }

    public double Media
    {
        get { return (Nota1 + Nota2) / 2; }
    }
    
    public string Situacao
    {
        get
        {
            return Media >= 6.0 ? "Aprovado" : "Reprovado" ;
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        Estudante e1 = new Estudante("Lucas Gabriel");

        e1.Nota1 = 5.0;
        e1.Nota2 = 4.0;

        Console.WriteLine("---- Informações sobre o(a) estudante ----");
        Console.WriteLine($"Estudante: {e1.Nome}");
        Console.WriteLine($"Média: {e1.Media}");
        Console.WriteLine($"Situação do estudante: {e1.Situacao}");

    }
}
