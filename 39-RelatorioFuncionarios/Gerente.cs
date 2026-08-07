public class Gerente : Funcionario
{

    public Gerente (string nome, string departamento) : base (nome, departamento){}


    public override void GerarRelatorio()
    {
        Console.WriteLine("\n---- Gerando Relatório -----");
        Console.WriteLine($"A função do Gerente {Nome} do departamento {Departamento} é supervisonar a equipe! ");
        
    }
}