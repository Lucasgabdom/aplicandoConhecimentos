public class ReservaOnline : Reserva
{
    public string Localizacao { get; set; }

    public ReservaOnline(string localizacao) {
        Localizacao = localizacao;
    }

    public override void Confirmar()
    {
        Console.WriteLine("---- Confirmando Reserva ----");
        Console.WriteLine($"Confirmando reserva online: {Localizacao}");
    }

}