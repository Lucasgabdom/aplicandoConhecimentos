class Funcionario
{
    public string Nome { get; set; }
    public string Cargo { get; set; }

    public Funcionario (string nome, string cargo)
    {
        Nome = nome;
        Cargo = cargo;
    }
}

class Freelancer : Funcionario
{
    public decimal ValorProjeto { get; set; }

    public Freelancer (string nome, string cargo, decimal valorProjeto) : base(nome, cargo)
    {
        ValorProjeto = valorProjeto;
    }
}

class Interno : Funcionario
{
    public decimal Salario { get; set; }
    public Interno(string nome, string cargo, decimal salario) : base(nome, cargo)
    {
        Salario = salario;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Freelancer f1 = new Freelancer("Lucas", "Desenvolvedor", 5000.00m);
        Interno f2 = new Interno("Daniel", "Analista", 4000.00m);

        Console.WriteLine($"Freelancer: {f1.Nome}, Cargo: {f1.Cargo}, Valor do Projeto: {f1.ValorProjeto}");
        Console.WriteLine($"Funcionário: {f2.Nome}, Cargo: {f2.Cargo}, Salário: {f2.Salario}");
    }
}