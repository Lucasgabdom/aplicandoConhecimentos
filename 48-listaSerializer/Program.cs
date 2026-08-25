using System.Text.Json;


//Criei um lista para poder guardar as pessoas que forem instaciadas 
List<Pessoa> pessoas = new List<Pessoa>();

while (true)
{
    Pessoa pessoa = new Pessoa();
    Console.WriteLine("\n----- Seja Bem-vindo ao cadastro de colaboradores ----\n");
    Console.WriteLine("Nome do colaborador ou digite 'sair' para poder encerrar o cadastro. ");
    string nome = Console.ReadLine()!;

    //verificação, se o usuário digitar "sair" o programa entende que deve ser encerrado.
    if (nome.ToLower() == "sair")
        break;
    

    // Aqui eu digo. O que foi escrito em nome, vai ser guardado em Nome.
    pessoa.Nome = nome;

    Console.WriteLine("\nIdade: ");
    pessoa.Idade = int.Parse(Console.ReadLine()!);

    Console.WriteLine("\nE-mail: ");
    pessoa.Email = Console.ReadLine()!;

    //Adicionando o perfil na lista

    pessoas.Add(pessoa);
        
}

//================================
//Serializando o arquivo
//================================

//Transformando os objetos C# em JSON>

string criandoArquivo = JsonSerializer.Serialize(pessoas);

//================================
//Criando/escrevendo arquivo JSON
//================================

string nomeDoArquivo = "colaboradores.json";

File.WriteAllText(nomeDoArquivo, criandoArquivo);

Console.WriteLine($"Os dados foram salvos em {nomeDoArquivo}");


//================================
//Lendo o arquivo JSON
//================================

string json = File.ReadAllText(nomeDoArquivo);


//================================
//Deserializando o arquivo
//================================

List<Pessoa>? colaboradores = JsonSerializer.Deserialize<List<Pessoa>>(json);

//================================
//Exibindo os dados
//================================

foreach (var funcionarios in colaboradores!)
{
    Console.WriteLine("\n---- Exibindo informações -----\n");
    Console.WriteLine($"Nome do colaborador: {funcionarios.Nome}");
    Console.WriteLine($"Idade do colaborador: {funcionarios.Idade}");
    Console.WriteLine($"E-mail do colaborador: {funcionarios.Email}");
    Console.WriteLine();
}



