public class RelatorioTarefa : IExecucao
{
    public void Executar()
    {
        Console.WriteLine("\n**** Processando relatório ****");
        Console.WriteLine($"----50%----");
        Console.WriteLine("---- 100% ----");
        Console.WriteLine("Relatório concluído com sucesso!");
    }
}