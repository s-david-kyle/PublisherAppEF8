using Microsoft.EntityFrameworkCore;
using PublisherDomain;

namespace PublisherData;

public class PubContext : DbContext
{
    public DbSet<Author> Authors { get; set; }
    public DbSet<Book> Books { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Data Source=davaputer;Initial Catalog=PubDatabase;User ID=sa;Password=Alpha155;Trust Server Certificate=True");
    }
}
