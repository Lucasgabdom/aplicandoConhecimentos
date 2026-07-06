public class Funcionario
{
    public string Nome { get; set; }
    private double salario { get; set; }

    public Funcionario(string nome, double salario)
    {
        Nome = nome;
        this.salario = salario;
    }
}

public class Gerente : Funcionario
{
    public string Setor { get; set; }

    public Gerente (string nome, double salario, string setor) : base("Daniel", 8000)
    {
        Setor = setor;
    }
}

public class Programador : Funcionario
{
    public string Linguagem { get; set; }

    public Programador (string nome, double salario, string linguagem) : base("Lucas Gabriel", 12.000)
    {
        Linguagem = linguagem;
    }
}

public class Analista : Funcionario
{
    public string Ferramenta { get; set; }

    public Analista (string nome, double salario, string ferramenta) : base("João", 6000)
    {
        Ferramenta = ferramenta;
    }
}
