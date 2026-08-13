List<Transporte> opcoes = new List<Transporte> { 
    new Onibus(),
    new Bicicleta(),
    new Metro(),
};

int km = 10;

foreach (var opcao in opcoes)
{
    Console.WriteLine($"{opcao.GetType().Name}: {opcao.Exibir(km)} min.");
}