Console.WriteLine("Hello, World!");
interface ICursos
{
    void ValidarConteudo();
    void PublicarConteudo();
}

class Instrutor
{
    public string Nome {  get; set; }
    public string Especialidade { get; set; }

    public Instrutor (string nome, string especialidade)
    {
        Nome = nome;
        Especialidade = especialidade;
    }       
}

class CursoProgramacao : ICursos
{
    private string Titulo;
    private Instrutor Instrutor;

    public CursoProgramacao(string titulo, Instrutor instrutor)
    {
        Titulo = titulo;
        Instrutor = instrutor;
    }

    public void ValidarConteudo() {
        Console.WriteLine($"Validando conteúdo do curso de programação: {Titulo}");
    }
    public void PublicarConteudo() {
        Console.WriteLine($"Curso publicado com sucesso: {Titulo} - Instrutora: {Instrutor.Nome} ({Instrutor.Especialidade})\n");
    }
}

class CursoDesign
{
    private string Titulo;
    private Instrutor Instrutor;

    public CursoDesign(string titulo, Instrutor instrutor)
    {
        Titulo = titulo;
        Instrutor = instrutor;
    }

    public void ValidarConteudo() 
    {
        Console.WriteLine($"Validando conteúdo do curso de programação: {Titulo}");
    }

    public void PublicarConteudo() 
    {
        Console.WriteLine($"Curso publicado com sucesso: {Titulo} - Instrutora: {Instrutor.Nome} ({Instrutor.Especialidade})\n");
    }

}

