public class Calculadora
{
    public double Calculo;

    public Calculadora() { }

    public void Somar (int numero1, int numero2)
    {
        Calculo = numero1 + numero2;
        Console.WriteLine(Calculo);
    }

    public void Somar(int numero1, int numero2, int numero3)
    {
        Calculo = numero1 + numero2 + numero3;
        Console.WriteLine(Calculo);
    }

    public void Somar(double numero1, double numero2)
    {
        Calculo = (double) numero1 + numero2;
        Console.WriteLine(Calculo);
    }
}

class Program
{
    static void Main(string[] args)
    {
        Calculadora cal = new Calculadora();

        cal.Somar(10,20);
        cal.Somar(10, 20, 30);
        cal.Somar(3.5, 3.2);

    }
}