class Pessoas
{
    public string Nome { get; set; }
    public string Email { get; set; }

    public Pessoas(string nome, string email)
    {
        Nome = nome;
        Email = email;
    }
}

interface IPagamento
{
    void Pagar();

    void ProcessarPagamento();
}

class PagamentoCredito : Pessoas, IPagamento
{
    public decimal NumeroCartao { get; set; }
    public string DataValidade { get; set; }
    public decimal CodigoSeguranca { get; set; }

    public PagamentoCredito(string nome, string email, decimal numeroCartao, string dataValidade, decimal codigoSeguranca)
        : base(nome, email)
    {
        NumeroCartao = numeroCartao;
        DataValidade = dataValidade;
        CodigoSeguranca = codigoSeguranca;
    }

    public void ProcessarPagamento()
    {
        Console.WriteLine($"Processando pagamendo no cartão {NumeroCartao}");
    }

    public void Pagar()
    {
        Console.WriteLine($"Pagamento realizado com sucesso no cartão {NumeroCartao}");
    }
}

class PagamentoBoleto : Pessoas, IPagamento
{
    public decimal CPFCNPJ { get; set; }

    public PagamentoBoleto(string nome, string email, decimal cpfcnpj) : base(nome, email)
    {
        CPFCNPJ = cpfcnpj;

    }

    public void ProcessarPagamento()
    {
        Console.WriteLine($"Boleto emito para pagamento no CPF/CNPJ {CPFCNPJ}");
    }

    public void Pagar()
    {
        Console.WriteLine($"Pagamento realizado com sucesso!");
    }

}

class Program
{
    static void Main(string[] args)
    {
        PagamentoBoleto cliente1 = new PagamentoBoleto("Lucas", "gabriellucaswbtrombone@gmail.com.br", 55553);
        cliente1.ProcessarPagamento();

        PagamentoCredito cliente2 = new PagamentoCredito("Lucas", "gabriellucaswbtrombone@gamil.com.br", 123455, "08/27", 776);
        cliente2.ProcessarPagamento();
        cliente2.Pagar();

    }
}