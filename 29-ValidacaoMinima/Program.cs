using System.Security.Cryptography.X509Certificates;

internal class Avalicao
{
    public string Aluno { get; }
    public double Nota { get; private set; }

    public Avalicao(string aluno)
    {
        Aluno = aluno;
    }

    public void AtribuirNota(double nota)
    {
        Nota = nota;

        if (nota > 0 && nota <= 10)
        {
            Console.WriteLine("\n---- Atribuição de Notas -----");
            Console.WriteLine($"Nota atribuida para Aluno(a): {Aluno}");
            Console.WriteLine($"Nota atribuida: {Nota}");
        } else
        {
            Console.WriteLine("\nErro: nota tem que ser maior que 0 e menor que 10!");
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        Avalicao aluna1 = new Avalicao("Lucas Gabriel");

        aluna1.AtribuirNota(8);
        aluna1.AtribuirNota(12);
    }
}
