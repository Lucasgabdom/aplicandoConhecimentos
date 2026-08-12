public class BackupTarefa : IExecucao
{
    public void Executar()
    {
        Console.WriteLine("\n**** Processando backup ****");
        Console.WriteLine($"----50%----");
        Console.WriteLine("---- 100% ----");
        Console.WriteLine("Backup concluído com sucesso!");
    }
}