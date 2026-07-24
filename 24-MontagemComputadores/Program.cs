class Processador
{
    public string Modelo { get; set; }
    public string Marca { get; set; }

    public Processador(string modelo, string marca)
    {
        Modelo = modelo;
        Marca = marca;
    }
}

class PlacaMae
{
    public string Fabricante { get; set; }
    public string Soquete { get; set; }

    public PlacaMae(string fabricante, string soquete)
    {
        Fabricante = fabricante;
        Soquete = soquete;
    }
}

class Computador
{
    private Processador Cpu;
    private PlacaMae Mobo;

    public Computador(Processador cpu, PlacaMae mobo)
    {
        Cpu = cpu;
        Mobo = mobo;
    }

    public void ExibirConfiguracao()
    {
        Console.WriteLine("Computador configurado com:");
        Console.WriteLine($"Processador: {Cpu.Marca} - {Cpu.Modelo}");
        Console.WriteLine($"Placa-mãe: {Mobo.Fabricante} - {Mobo.Soquete}");
    }
}