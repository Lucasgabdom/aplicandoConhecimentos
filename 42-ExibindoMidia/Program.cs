List<Midia> midias = new List<Midia>
{
    new Video("velozes e furiosos", 240),
    new Imagem("Foto em familia", "1920x1080"),
    new Video("aniversario do Lucas", 150),
    new Imagem("Foto divertidamente", "1280x720")
};

foreach (var midia in midias)
{
    midia.ExibirInformacoes();
}