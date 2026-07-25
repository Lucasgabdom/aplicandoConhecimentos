using System.Security.Cryptography.X509Certificates;

internal class Veiculo
{
    public string Placa { get; }
    public double VelocidadeAtual { get; private set; }
   
    
    public Veiculo (string placa, double velocidadeAtual)
    {
        Placa = placa;
        VelocidadeAtual = velocidadeAtual;
    }

    public void ExibirInformacoes()
    {
        Console.WriteLine("\n---- Dados do Veículo ----");
        Console.WriteLine($"Veículo: {Placa}");
        Console.WriteLine($"Velocidade atual: {VelocidadeAtual} km/h");
    }

    public void AtualizarVelocidade(double novaVelocidade)
    {
        
        VelocidadeAtual = novaVelocidade;
        
        Console.WriteLine("\n---- Velocidade Alterada ----");
        Console.WriteLine($"Velocidade atualizada para: {novaVelocidade} km/h");
    }

    

}

class Program
{
    static void Main(string[] args)
    {
        Veiculo veiculo = new Veiculo("ABC-1234", 75);

        veiculo.ExibirInformacoes();
        veiculo.AtualizarVelocidade(60);

    }
}



