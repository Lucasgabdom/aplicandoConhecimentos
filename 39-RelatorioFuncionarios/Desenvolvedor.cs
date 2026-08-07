public class Desenvolvedor : Funcionario
{
    public Desenvolvedor (string nome, string departamento) : base (nome, departamento) { }

    public override void GerarRelatorio()
    {
        Console.WriteLine("\n---- Gerando Relatório -----");
        Console.WriteLine($"A função do desenvolvedor {Nome}: escrever código e corrigir bugs.");
    }
}