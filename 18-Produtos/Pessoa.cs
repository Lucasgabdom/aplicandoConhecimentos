public class Pessoa {
    public string Nome { get; set; }
    public int Idade { get; set; }

    public Pessoa (string nome, int idade)
    {
        this.Nome = nome;
        this.Idade = idade;
    }
}

public class ClienteVIP : Pessoa 
{
    public string NivelVIP { get; set; }
    public string CodigoVIP { get; set; }

    public ClienteVIP(string nivelVIP, string codigoVIP, string nome, int idade) : base(nome, idade)
    {
        this.NivelVIP = nivelVIP;
        this.CodigoVIP = codigoVIP;
    }   

}






