List<Reserva> reserva = new List<Reserva>
{
    new ReservaPrencial("Passa Quatro"),
    new ReservaOnline("Workshop de programação")
};

foreach (var feito in reserva)
{
    feito.Confirmar();
}