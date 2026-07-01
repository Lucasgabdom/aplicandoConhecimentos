using Alura.Filmes;

Filme filme = new Filme("Velozes e furioso", 240, new List<string>() { "Pual Warker", "Toretto" });
Filme filme2 = new Filme("O senhor dos aneis", 340, new List<string>() { "hobbit", "Bilbo", "Frodo"});

List<Filme> meusFilmesFavoritos = new List<Filme>();
meusFilmesFavoritos.Add(filme);
meusFilmesFavoritos.Add(filme2);

foreach(Filme f in meusFilmesFavoritos)
{
    Console.WriteLine($"Filme: {f.Titulo}");
    Console.WriteLine($"Duracao: {f.Duracao}");
    f.ExibirElenco();
    Console.WriteLine();
}


