public class PushNotificacao: INotificacao
{
    public void EnviarMensagem(string mensagem)
    {
        Console.WriteLine($"Enviando push com a seguinte mensagem: {mensagem}");
    }
}

