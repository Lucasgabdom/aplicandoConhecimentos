public interface ISensor
{
    public void Ativar();
    public void Desativar();
}

class SensorTemperatura : ISensor
{
    public void Ativar()
    {
        Console.WriteLine("Sensor de Temperatura ativado.");
    }
    public void Desativar()
    {
        Console.WriteLine("Sensor de Temperatura desativado.");
    }
}

class SensorPresenca : ISensor
{
    public void Ativar()
    {
        Console.WriteLine("Sensor de Presença ativado.");
    }
    public void Desativar()
    {
        Console.WriteLine("Sensor de Presença desativado.");
    }
}

class Program
{
    static void Main(string[] args)
    {
        ISensor sensorTemp = new SensorTemperatura();
        ISensor sensorPresenca = new SensorPresenca();
        sensorTemp.Ativar();
        sensorTemp.Desativar();
        sensorPresenca.Ativar();
        sensorPresenca.Desativar();
    }
}