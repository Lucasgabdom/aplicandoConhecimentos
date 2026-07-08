public interface IArmazenavel
{
    void Salvar();
    void Recuperar();
}

public class Arquivo : IArmazenavel
{
    public string NomeArquivo { get; set; }
    public string Caminho { get; set; }

    public void Salvar()
    {
        Console.WriteLine($"{NomeArquivo} salvo em {Caminho}.");
    }
    public void Recuperar() {
        Console.WriteLine($"Recuperando {NomeArquivo} de {Caminho}.");          
    }
}

public class BancoDeDados : IArmazenavel
{
    public string NomeTabela { get; set; }
    public string Conexao { get; set; }
    public void Salvar()
    {
        Console.WriteLine($"Dados salvos na tabela {NomeTabela} usando a conexão {Conexao}.");
    }
    public void Recuperar()
    {
        Console.WriteLine($"Recuperando dados da tabela {NomeTabela} usando a conexão {Conexao}.");
    }
}