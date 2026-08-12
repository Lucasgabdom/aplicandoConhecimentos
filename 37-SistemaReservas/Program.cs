internal class Hospede
{
    public string Nome {  get; }

    public Hospede(string nome)
    {
        Nome = nome;
    }
}

internal class Quarto
{
    public int Numero { get; set; }
    private decimal valorDiaria;
    public decimal ValorDiaria
    {
        get => valorDiaria;
        set
        {
            if (value <= 0)
                throw new ArgumentException("O valor da diária deve ser positivo.");
            valorDiaria = value;
        }
    }

    public Quarto(int numero, decimal valorDiaria)
    {
        Numero = numero;
        ValorDiaria = valorDiaria;
    }


}

internal class Reserva
{
    private int Diarias;
    public Hospede Hospede{ get; }
    public Quarto Quarto { get; }

    public decimal ValorTotal => Diarias * Quarto.ValorDiaria;

    public Reserva(Hospede hospede, Quarto quarto, int diarias)
    {
        if (diarias <= 0) throw new ArgumentException("A quantidade de diárias deve ser maior que zero.");
        
        Hospede = hospede;
        Quarto = quarto;
        Diarias = diarias;
    }

    public void ExibirInformacoes()
    {
        Console.WriteLine($"\n---- Informações sobre a Reserva ----");
        Console.WriteLine($"Hospede: {Hospede.Nome}");
        Console.WriteLine($"Quarto: {Quarto.Numero}");
        Console.WriteLine($"Valor Total: {ValorTotal}");
    }

}


class Program
{
    static void Main()
    {  
        Quarto simples = new Quarto(003, 150.00m);
        Quarto suite = new Quarto(001, 300.00m);
        Quarto media = new Quarto(002, 220.00m);

        Hospede hospede = new Hospede("Lucas Gabriel");
        Reserva reserva = new Reserva(hospede, simples, 2);

        Hospede h2 = new Hospede("Daniel Faustino");
        Reserva r2 = new Reserva(h2, media, 2);

        Hospede h3 = new Hospede("Cristiane");
        Reserva r3 = new Reserva(h3, suite, 2);

        reserva.ExibirInformacoes();
        r2.ExibirInformacoes();
        r3.ExibirInformacoes();

    }
}