public class ReservaPrencial : Reserva
{
    public string Nome {  get; set; }

    public ReservaPrencial(string nome) {  Nome = nome; }

    public override void Confirmar()
    {
        Console.WriteLine($"Confirmando reserva presencial: {Nome}");
    }


}

