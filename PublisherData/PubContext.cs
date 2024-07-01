using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using PublisherDomain;

namespace PublisherData;

public partial class PubContext : DbContext
{
    public DbSet<Author> Authors { get; set; }
    public DbSet<Book> Books { get; set; }
    public DbSet<Cover> Covers { get; set; }
    public DbSet<Artist> Artists { get; set; }

    public PubContext(DbContextOptions<PubContext> options) : base(options)
    {

    }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        if (!optionsBuilder.IsConfigured)
        {

            var connectionString = "Data Source=davaputer;Initial Catalog=PubDatabase;User ID=sa;Password=Alpha155;Trust Server Certificate=True";
            optionsBuilder
                .UseSqlServer(connectionString)
                .LogTo(Console.WriteLine,
                    new[] { DbLoggerCategory.Database.Command.Name },
                    LogLevel.Information)
                .EnableSensitiveDataLogging();
        }
    }
}
