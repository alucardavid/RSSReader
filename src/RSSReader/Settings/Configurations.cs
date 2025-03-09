using Microsoft.Extensions.Configuration;


namespace RSSReader.Settings;

public static class Configurations 
{
    private static IConfiguration BuildConfiguration()
    {
        return new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
            .AddUserSecrets("3c55462f-62af-4709-99dd-3bc1cfa1e358")
            .Build();
    }

    public static DbSettings DbSetting
    {
        get
        {
            var _config = BuildConfiguration();
            return _config
                .GetSection(DbSettings.Section)
                .Get<DbSettings>() ??
                throw new ArgumentException("Section not implemented!");
        }
    }


}
