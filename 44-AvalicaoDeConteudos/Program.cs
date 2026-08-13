List<Conteudo> conteudos = new List<Conteudo>
{
    new MaterialGravado("Introdução ao C#", 45),
    new MaterialComplementar("Documentação Oficial do C#", "https://docs.microsoft.com/pt-br/dotnet/csharp/"),
};

foreach (var conteudo in conteudos)
{
    conteudo.Exibir();
}