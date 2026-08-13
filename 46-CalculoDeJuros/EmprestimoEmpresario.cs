public class EmprestimoEmpresario: IEmprestimo
{
    public void CalcularEmprestimo(decimal valor, int parcelas)
    {
        decimal taxaJuros = 0.025m; // 2.5% de juros ao mês
        decimal valorTotal = valor + (valor * taxaJuros * parcelas);
        Console.WriteLine($"\n\n---- Emprestimo Empresario ----");
        Console.WriteLine($"Valor total do empréstimo para empresário: {valorTotal:C}");
    }
}