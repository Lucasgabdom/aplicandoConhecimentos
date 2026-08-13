public class EmprestimoAposentado : IEmprestimo
{
    public void CalcularEmprestimo(decimal valor, int parcelas)
    {
        decimal taxaJuros = 0.015m; // 1.5% de juros ao mês
        decimal valorTotal = valor + (valor * taxaJuros * parcelas);
        Console.WriteLine($"\n\n---- Emprestimo Aposentado ----");
        Console.WriteLine($"Valor total do empréstimo para aposentado: {valorTotal:C}");
    }
}