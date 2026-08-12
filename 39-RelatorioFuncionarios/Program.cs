class Program
{
    static void Main(string[] args)
    {
        Funcionario f1 = new Gerente("Lucas gabriel", "TI");
        Funcionario f2 = new Desenvolvedor("Daniel Faustino", "TI");

        f1.GerarRelatorio();
        f2.GerarRelatorio();
    }
}