List<IAcaoBotao> acoes = new List<IAcaoBotao>
{
    new Editar(),
    new ExcluirAcao(),
    new SalvarAcao(),
};

foreach (var aco in acoes)
{
    aco.Executar();
}