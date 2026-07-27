using System.Globalization;

internal class ContaBancaria
{
    public string Titular {  get; set; }
    public double Saldo { get; private set; }

    public ContaBancaria (string titular, double saldo)
    {
        Titular = titular;
        Saldo = saldo;
    }

    public void Sacar(double valor)
    {
        SegurancaConta conta = new SegurancaConta();

        if (conta.ValidarSaquer(valor) && valor < Saldo)
        {
            Saldo = Saldo - valor;

            Console.WriteLine("\n---- Informações da conta ----");
            Console.WriteLine($"Valor de R${valor} sacado com sucesso.");
            Console.WriteLine($"Seu saldo atual é de R${Saldo.ToString("F2", CultureInfo.InvariantCulture)}");
        } else
        {
            Console.WriteLine("\nErro: Você não pode realizar o saque, consulte o seu banco para mais informações.");
        }
    }
}

internal class SegurancaConta
{
    public bool ValidarSaquer(double valor) 
    {
        return valor <= 1000;
    }
}

class Program
{
    static void Main(string[] args)
    {
        ContaBancaria conta1 = new ContaBancaria("Lucas Gabriel", 3500);


        conta1.Sacar(500);
        conta1.Sacar(1500);

        ContaBancaria conta2 = new ContaBancaria("Layza", 300);

        conta2.Sacar(500);
        conta2.Sacar(150);


    }
}

