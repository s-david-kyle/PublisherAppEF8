using Microsoft.EntityFrameworkCore;
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

}
