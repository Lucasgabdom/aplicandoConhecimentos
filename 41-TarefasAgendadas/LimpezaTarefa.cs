public class LimpezaTarefa : IExecucao
{
    public void Executar()
    {
        Console.WriteLine("\n**** Processando limpeza ****");
        Console.WriteLine($"----50%----");
        Console.WriteLine("---- 100% ----");
        Console.WriteLine("Limpeza concluída com sucesso!");
    }
}