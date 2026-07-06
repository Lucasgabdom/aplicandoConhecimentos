namespace _09_FormasGeometricas;

internal class Compilacao
{
    public void Executar()
    {
        List<FormaGeometrica> formas = new List<FormaGeometrica>
        {
            new Quadrado(5),
            new Circulo(3),
            new Triangulo(3, 4)
        };

        foreach (var forma in formas)
        {
            forma.MostrarInfo();
        }
    }
}