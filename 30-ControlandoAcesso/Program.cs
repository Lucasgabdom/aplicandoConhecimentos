using System.Security.Cryptography.X509Certificates;

public class Paciente
{
    public string Nome { get; set; }
    public int Idade { get; set; }

    public Paciente (string nome, int idade)
    {
        Nome = nome;
        Idade = idade;
    }
}

internal class HistoricoMedico : Paciente
{
    public string CodigoProntuario { get; private set; }

    public HistoricoMedico  (string codigoProntuario, string nome, int idade) : base (nome,idade)
    {
        CodigoProntuario = codigoProntuario;
    }

    public void ExibirCodigo()
    {
        Console.WriteLine("---- Prontuário do Paciente -----");
        Console.WriteLine($"Nome do Paciente: {Nome}");
        Console.WriteLine($"Idade do Paciente: {Idade}");
        Console.WriteLine($"Código do prontuário: {CodigoProntuario}");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Paciente p1 = new Paciente("Daniel Faustino", 45);
        HistoricoMedico hitoricop1 = new HistoricoMedico("XPT-9997", "Lucas Gabriel", 45);

        hitoricop1.ExibirCodigo();
        
    }
}