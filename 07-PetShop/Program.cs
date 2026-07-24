class Pet
{
    public string Nome { get; set; }
    public int Idade { get; set; }
    public string Especie { get; set; }

    public Pet(string nome, int idade, string especie)
    {
        Nome = nome;
        Idade = idade;
        Especie = especie;
    }
}

class Dono
{
    public string Nome { get; set; }
    public string Contato { get; set; }

    public Dono (string nome, string contato)
    {
        Nome = nome;
        Contato = contato;
    }
    
}

class Medico
{
    public string Nome { get; set; }
    public string Especialidade { get; set; }
    public Medico(string nome, string especialidade)
    {
        Nome = nome;
        Especialidade = especialidade;
    }
} 

class Consulta
{
    public Pet Animal { get; set; }
    public Dono DonoAnimal { get; set; }
    public Medico Veterinario { get; set; }
    public DateTime DataConsulta { get; set; }

    public Consulta(Pet animal, Dono donoAnimal, Medico veterinario, DateTime dataConsulta)
    {
        Animal = animal;
        DonoAnimal = donoAnimal;
        Veterinario = veterinario;
        DataConsulta = dataConsulta;
    }
}