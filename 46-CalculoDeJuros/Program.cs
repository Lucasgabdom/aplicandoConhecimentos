List<IEmprestimo> perfis = new List<IEmprestimo>
{
    new EmprestimoEstudante(),
    new EmprestimoAposentado(),
    new EmprestimoEmpresario()
};

foreach (var perfil in perfis)
{
    perfil.CalcularEmprestimo(1000, 12);
}