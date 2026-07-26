using System.Globalization;

internal class Funcionario
{
    public string Nome { get; set; }
    public double Salario { get; private set; }

    public Funcionario(string nome, double salario)
    {
        Nome = nome;
        Salario = salario;
    }

    public void ExibirInformacoes()
    {
        Console.WriteLine("\n---- Informações do Funcionário ----");
        Console.WriteLine($"Nome: {Nome}");
        Console.WriteLine("Salário: R$" + Salario.ToString("F2"));
    }

    public void ReajustarSalario(double novoValor)
    {
        if (novoValor > Salario) {
            
            
            Salario = novoValor;
            Console.WriteLine("\n---- Salário Reajustado ----");
            Console.WriteLine("Salario do funcionário" + Nome + "reajustado: R$" + Salario.ToString("F2"));
        } else
        {
            Console.WriteLine("\nErro: O novo salário tem que ser maior que o atual.");
        }
        
    }

    
}

class Program
{
    static void Main(string[] args)
    {
        Funcionario p1 = new Funcionario("Lucas Gabriel", 4000);
        p1.ExibirInformacoes();
        p1.ReajustarSalario(8000);
        p1.ExibirInformacoes();
        p1.ReajustarSalario(4000);
    }
}