class Consulta
{
    public string NomePaciente { get; set; }
    public string NomeMedico { get; set; }
    public DateTime DataConsulta { get; set; }

    public bool Reagendado;

    public Consulta(string nomePaciente, string nomeMedico, DateTime dataConsulta)
    {
        NomePaciente = nomePaciente;
        NomeMedico = nomeMedico;
        DataConsulta = dataConsulta;
        Reagendado = false;
    }

    public void ReagendarConsulta(DateTime novaData)
    {
        DataConsulta = novaData;
        Reagendado = true;
        Console.WriteLine($"Consulta reagendada para {novaData:dd/MM/yyyy}");
        Console.WriteLine();

    }

    public void ExibirConsulta()
    {
        Console.WriteLine($"Consulta marcado com {NomeMedico} para o paciente {NomePaciente}.");
        if (Reagendado) {
            Console.WriteLine($"Nova data: {DataConsulta:dd/MM/yyyy}");
        }
        else
        {
            Console.WriteLine($"Data da consulta: {DataConsulta:dd/MM/yyyy}");
        }
        Console.WriteLine();
    }
}