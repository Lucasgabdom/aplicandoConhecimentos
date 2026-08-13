public class MaterialComplementar : Conteudo
{
    public string Titulo { get; set; }
    public string Pagina { get; set; }
    public MaterialComplementar(string titulo, string pagina)
    {
        Titulo = titulo;
        Pagina = pagina;
    }
    public override void Exibir()
    {
        Console.WriteLine("---- Exibindo Material Complementar ----");
        Console.WriteLine($"Título: {Titulo}");
        Console.WriteLine($"Material complementar: {Pagina}");
    }
}