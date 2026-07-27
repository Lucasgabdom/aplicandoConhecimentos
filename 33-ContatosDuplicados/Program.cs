internal class Contato
{
    public string Nome {  get; set; }
    public string Telefone { get; set; }

    public Contato (string nome, string telefone)
    {
        Nome = nome;
        Telefone = telefone;
    }


}

internal class Agenda
{
    public string Proprietario { get; set; }
    private readonly List<Contato> contatos;
    
    public Agenda(string proprietario)
    {
        Proprietario = proprietario;
        contatos = new List<Contato>();
    }

    public bool AdicionarContato(Contato contato)
    {
        if (contatos.Any(c => c.Nome == contato.Nome))
        {
            Console.WriteLine("Contato com esse nome já foi adicionado");
            return false;
        }

        contatos.Add(contato);
        return true;
    }

    public void ListarContatos()
    {
        Console.WriteLine();
        Console.WriteLine($"---- agenda da(o) {Proprietario} ----");
        foreach (Contato c in contatos)
        {
            Console.WriteLine($"- {c.Nome} | {c.Telefone}");
        }
        Console.WriteLine($"Total de contatos {QuantidadeContatos}");
    }

    public int QuantidadeContatos
    {
        get { return contatos.Count;}
    }

}

class Program
{
    static void Main(string[] args)
    {
        Agenda agenda1 = new Agenda("Lucas Gabriel");

        agenda1.AdicionarContato(new Contato("Daniel Faustino", "12981994051"));
        agenda1.AdicionarContato(new Contato("Daniel Faustino", "12981994051"));
        agenda1.AdicionarContato(new Contato("Cristiane", "129888888888"));
        agenda1.ListarContatos();
    }
}