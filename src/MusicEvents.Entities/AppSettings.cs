namespace MusicEvents.Entities;

public class AppSettings
{
    public StorageConfiguration StorageConfiguration { get; set; }
    public Jwt Jwt { get; set; }

    public MailConfiguration MailConfiguration { get; set; }
    public ConnectionStrings ConnectionStrings { get; set; }

}

public class ConnectionStrings
{
    public string Default { get; set; }
}

public class MailConfiguration
{
    public string SmtpServer { get; set; }
    public string UserName { get; set; }
    public string Password { get; set; }
    public int Port { get; set; }
    public string FromAddress { get; set; }
    public string FromName { get; set; }
}

public class StorageConfiguration
{
    public string Path { get; set; }
    public string PublicUrl { get; set; }
}

public class Jwt
{
    public string Issuer { get; set; }
    public string Audience { get; set; }
    public string SigningKey { get; set; }
}
