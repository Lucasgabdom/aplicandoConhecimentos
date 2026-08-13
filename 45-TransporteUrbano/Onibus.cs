public class Onibus: Transporte
{
    public override int Exibir(int km)
    {
        return (km * 2) + 5;
    }
}