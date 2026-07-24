public class Conta
{
    public string Titular { get; set; }
    public double Saldo { get; set; }

    public Conta (string titular, double saldo)
    {
        this.Titular = titular;
        this.Saldo = saldo;
    }

    public void Depositar(double valor)
    {
        this.Saldo += valor;
    }

    public void Sacar(double valor)
    {
        if (this.Saldo > 0)
        {
            this.Saldo -= valor;
        }
        else
        {
            Console.WriteLine("Não é possível realizar o saque.");
        }
    }

    public void MostrarInfo()
    {
        Console.WriteLine($"Titular: {Titular}, Saldo: {Saldo:F2}");
    }

}   