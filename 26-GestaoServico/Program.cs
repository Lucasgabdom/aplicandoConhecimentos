interface IServico
{
    void ExecutarServico();

}

public class Funcionario
{
    public string Nome { get; set;}
    public string Departamento { get; set;}

    public Funcionario (string nome, string departamento)
    {
        this.Nome = nome;
        this.Departamento = departamento;
    }
}

public class Manutencao : IServico
{

    private string Titulo { get; set;}
    private Funcionario Responsavel;

    public Manutencao(string titulo, Funcionario responsavel)
    {
        Titulo = titulo;
        Responsavel = responsavel;
    }

    public void ExecutarServico()
    {
        Console.WriteLine($"Executando serviço de manutenção: {Titulo}");
        Console.WriteLine($"Responsável: {Responsavel.Nome} - Departamento: {Responsavel.Departamento}");
    }
}

public class Consultoria : IServico
{
    private string Nome { get; set;}
    private Funcionario Responsavel { get; set;}

    public Consultoria (string nome, Funcionario responsavel)
    {
        Nome = nome;
        Responsavel = responsavel;
    }
    
    public void ExecutarServico()
    {
        Console.WriteLine($"Executando serviço de consultoria: {Nome}");
        Console.WriteLine($"Responsável: {Responsavel.Nome} - Departamento: {Responsavel.Departamento}");
        
    }
}