internal class Projeto
{
    public string Nome { get; set; }
    private List<string> Tarefas;

    

    public Projeto (string nome)
    {
        Nome = nome;
        Tarefas = new List<string> ();
    }

    public void AdicionarTarefa(string tarefa)
    {
        Tarefas.Add (tarefa);
    }

    public void ExibirTarefas()
    {
        Console.WriteLine("---- Exibindo Tarefas ----");
        Console.WriteLine($"Nome do projeto: {Nome}");
        Console.WriteLine($"\n---- Tarefas ----");
        foreach ( string tarefa in Tarefas)
        {
            Console.WriteLine($" - {tarefa}");
        }
        Console.WriteLine($"\nTotal: {QuantidadeTarefa} tarefas.");
    }

    public int QuantidadeTarefa
    {
        get { return Tarefas.Count; }
    }

}

class Program
{
    static void Main(string[] args)
    {
        Projeto projeto = new Projeto("Sistema de Inventário");
        projeto.AdicionarTarefa("Criar tela de login");
        projeto.AdicionarTarefa("Implementar banco de dados");
        projeto.ExibirTarefas();

    }
}