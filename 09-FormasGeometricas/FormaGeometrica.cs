namespace _09_FormasGeometricas;

public abstract class FormaGeometrica
{
    public string Nome { get; set; }

    public FormaGeometrica(string nome)
    {
        this.Nome = nome;
    }

    public abstract double CalcularArea();
    public abstract double CalcularPerimetro();

    public void MostrarInfo()
    {
        Console.WriteLine($"{Nome} -> Área: {CalcularArea():F2}, Perímetro: {CalcularPerimetro():F2}");
    }
}