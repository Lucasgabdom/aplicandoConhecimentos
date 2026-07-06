namespace _09_FormasGeometricas;

public class Quadrado : FormaGeometrica
{
    public double Lado { get; set; }

    public Quadrado(double lado) : base("Quadrado")
    {
        Lado = lado;
    }

    public override double CalcularArea() => Lado * Lado;
    public override double CalcularPerimetro() => 4 * Lado;
}

public class Circulo : FormaGeometrica
{
    public double Raio { get; set; }

    public Circulo(double raio) : base("Círculo")
    {
        Raio = raio;
    }

    public override double CalcularArea() => Math.PI * Raio * Raio;
    public override double CalcularPerimetro() => 2 * Math.PI * Raio;
}

public class Triangulo : FormaGeometrica
{
    public double Base { get; set; }
    public double Altura { get; set; }

    public Triangulo(double base1, double altura) : base("Triângulo")
    {
        Base = base1;
        Altura = altura;
    }

    public override double CalcularArea() => (Base * Altura) / 2;

    public override double CalcularPerimetro()
    {
        double hipotenusa = Math.Sqrt((Base * Base) + (Altura * Altura));
        return Base + Altura + hipotenusa;
    }
}