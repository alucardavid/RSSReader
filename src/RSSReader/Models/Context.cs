using Microsoft.EntityFrameworkCore;
using RSSReader.Settings;

namespace RSSReader.Models;

public class Context : DbContext
{
    public DbSet<Rss> Rsses { get; set; }
    private DbSettings _dbSettings;

    public Context()
    {
        _dbSettings = Configurations.DbSetting;
    }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) 
        => optionsBuilder
            .UseNpgsql($@"
                Host={_dbSettings.Host};
                Password={_dbSettings.Password};
                Persist Security Info=True;
                Username={_dbSettings.User};
                Database={_dbSettings.Database}");
}    
