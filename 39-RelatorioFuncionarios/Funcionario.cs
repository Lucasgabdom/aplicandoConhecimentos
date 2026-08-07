public class Funcionario
{
    protected string Nome { get; set; }
    protected string Departamento { get; set; }

    public Funcionario(string nome, string departamento)
    {
        Nome = nome;
        Departamento = departamento;

    }

    public virtual void GerarRelatorio() 
    {
        Console.WriteLine("\n---- Gerando Relatório -----");
        Console.WriteLine($"Relatório genérico do funcionário {Nome} do departamento {Departamento}");
    }

}