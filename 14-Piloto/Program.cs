using static _14_Piloto.IIterface;

public class Carro : IPilotavel, IVoavel
{
    public void Pilotar()
    {
        Console.WriteLine("O carro está sendo pilotado.");
    }

    public void Voar()
    {
        Console.WriteLine("O carro está voando.");
    }
}