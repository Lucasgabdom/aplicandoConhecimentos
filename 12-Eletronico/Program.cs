public class Eletronico
{
    public string Marca { get; set; }
    public string Modelo { get; set; }
    public double Preco { get; set; }

    public Eletronico (string marca, string modelo, double preco)
    {
        this.Marca = marca;
        this.Modelo = modelo;
        this.Preco = preco;
    }
}

public class Smartphone : Eletronico
{
    public int Armazenamento { get; set; }
    public Smartphone(string marca, string modelo, double preco, int armazenamento) : base(marca, modelo, preco)
    {
        this.Armazenamento = armazenamento;
    }
}

public class Tablet : Eletronico
{
    public int TamanhoTela { get; set; }
    public Tablet(string marca, string modelo, double preco, int tamanhoTela) : base(marca, modelo, preco)
    {
        this.TamanhoTela = tamanhoTela;
    }
}

public class Notebook : Eletronico
{
    public int MemoriaRAM { get; set; }
    public string Processador { get; set; }
    public Notebook(string marca, string modelo, double preco, int memoriaRAM) : base(marca, modelo, preco)
    {
        this.MemoriaRAM = memoriaRAM;
    }
}