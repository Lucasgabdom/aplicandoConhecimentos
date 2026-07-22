public interface Inotificavel
{
    string EnviarNotificacao();
}

public class Email : Inotificavel
{
    public string Destinatario { get; set; }
    public string Assunto { get; set; }


    public string EnviarNotificacao()
    {
        return $"Enviando email para {Destinatario} com o assunto: {Assunto}";
    }
}

public class SMS : Inotificavel
{
    public string NumeorTelefone { get; set; }
    public string Mensagem { get; set; }

    public string EnviarNotificacao()
    {
        return $"Enviando SMS para {NumeorTelefone} com a mensagem: {Mensagem}";
    }
}