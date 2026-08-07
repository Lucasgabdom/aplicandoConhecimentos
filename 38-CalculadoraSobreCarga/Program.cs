using System.Data;

public class Calculadora
{
    public void Somar(int a, int b)
    {
        int Resultado = a + b;
        Console.WriteLine(Resultado);
    }

    public void Somar(int a, int b, int c) 
    {
        int Resultado = a + b + c;
        Console.WriteLine(Resultado);
    }

    public void Somar(double a, double b)
    {
        double Resultado = a + b;
        Console.WriteLine(Resultado);
    }
}

class Program
{
    static void Main(string[] args)
    {
        Calculadora cal = new Calculadora();

        cal.Somar (1, 2);
        cal.Somar(5, 10, 15);
        cal.Somar(5.2, 7.2);
    }
}

