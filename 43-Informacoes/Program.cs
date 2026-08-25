using System.Text.Json;

string fileName = "pessoa.json";

//Verifica se o arquivo existe
if (File.Exists(fileName))
{
     //Ler conteúdo do arquivo JSON
     string jsonString = File.ReadAllText(fileName);

    //Desserialize Json para o objeto pessoa
    Pessoa pessoa = JsonSerializer.Deserialize<Pessoa>(jsonString);

    // Exibindo informações de pessoa
    Console.WriteLine($"Nome: {pessoa.Nome}");
    Console.WriteLine($"Idade: {pessoa.Idade}");
    Console.WriteLine($"Email: {pessoa.Email}");
} else
{
    Console.WriteLine($"O arquivo {fileName} não existe.");
}