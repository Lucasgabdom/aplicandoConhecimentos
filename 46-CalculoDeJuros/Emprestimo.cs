public class EmprestimoEstudante : IEmprestimo
{
    public void CalcularEmprestimo(decimal valor, int parcelas)
    {
        decimal taxaJuros = 0.01m; // 1% de juros ao mês
        decimal valorTotal = valor + (valor * taxaJuros * parcelas);
        Console.WriteLine($"\n\n---- Emprestimo Estudante ----");
        Console.WriteLine($"Valor total do empréstimo para estudante: {valorTotal:C}");
    }
}