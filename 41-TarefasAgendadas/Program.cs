List<IExecucao> tarefas = new List<IExecucao>
{
    new BackupTarefa(),
    new LimpezaTarefa(),
    new RelatorioTarefa(),

};

foreach (var tarefa in tarefas)
{
    tarefa.Executar();
}