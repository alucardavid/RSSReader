namespace RSSReader.Settings;

public class DbSettings 
{
    public const string Section = "Db";
    public string? Host { get; set; }

    public string? Port { get; set; }
    public string? Database { get; set; }
    public string? User { get; set; }
    public string? Password { get; set; }

}