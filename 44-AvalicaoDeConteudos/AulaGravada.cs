public class MaterialGravado : Conteudo
{
    public string Titulo { get; set; }
    public int Duracao { get; set; } // Duração em minutos

    public MaterialGravado (string titulo, int duracao)
    {
        Titulo = titulo;
        Duracao = duracao;
    }

    public override void Exibir()
    {
        Console.WriteLine("---- Exibindo Material Gravado ----");
        Console.WriteLine($"Título: {Titulo}");
        Console.WriteLine($"Duração: {Duracao} minutos");
    }
}