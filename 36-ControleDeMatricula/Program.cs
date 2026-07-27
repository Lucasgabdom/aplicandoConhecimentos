public class Estudante
{
    public string Nome;

    public Estudante(string nome)
    {
        Nome = nome;
    }


}

public class Curso
{
    public string Nome { get; set; }
    public int VagasTotais { get; set; }

    private List<Estudante> Matriculas;

    public Curso(string nome, int vagasTotais)
    {
        Nome = nome;
        VagasTotais = vagasTotais;
        Matriculas = new List<Estudante>();
    }

    public bool Matricular(Estudante estudante)
    {
        if (Matriculas.Count >= VagasTotais)
        {
            Console.WriteLine("Erro: não a vagas disponíveis para esse curso no momento.");
            return false;
        }

        Matriculas.Add(estudante);
        Console.WriteLine("Estudante matriculado com sucesso!");
        return true;

    }

    public void ListarMatriculados()
    {
        Console.WriteLine($"Estudante matriculados em {Nome}: ");
        foreach (var estudante in Matriculas)
        {
            Console.WriteLine($"- " + estudante.Nome);    
        }
        Console.WriteLine($"Vagas disponíveis: {VagasDisponiveis}");
    }

    public int VagasDisponiveis
    {
        get { return VagasTotais - Matriculas.Count; }
    }
}

class Program
{
    static void Main(string[] args)
    {
        
        Curso a1 = new Curso("Engenharia de software", 2);

        a1.Matricular(new Estudante("Lucas Gabriel"));
        a1.Matricular(new Estudante("Douglas santos"));
        a1.Matricular(new Estudante("Diego"));
        a1.Matricular(new Estudante("Gabriel"));
        a1.Matricular(new Estudante("Thiago"));
    }
}
