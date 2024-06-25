using Microsoft.EntityFrameworkCore;
using PublisherDomain;

namespace PublisherData;

public class PubContext : DbContext
{
    public DbSet<Author> Authors { get; set; }
    public DbSet<Book> Books { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        var connectionString = "Data Source=davaputer;Initial Catalog=PubDatabase;User ID=sa;Password=Alpha155;Trust Server Certificate=True";
        optionsBuilder.UseSqlServer(connectionString);
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Author>().HasData(
            new Author { AuthorId = 1, FirstName = "Josie", LastName = "Newf" },
            new Author { AuthorId = 2, FirstName = "Jill", LastName = "Hill" },
            new Author { AuthorId = 3, FirstName = "Jack", LastName = "Black" },
            new Author { AuthorId = 4, FirstName = "Jen", LastName = "Ken" },
            new Author { AuthorId = 5, FirstName = "Jennifer", LastName = "Kensington" }
            );
        modelBuilder.Entity<Book>().HasData(
            new Book { BookId = 1, Title = "The Book of Josie", PublishDate = new DateOnly(2021, 10, 12), BasePrice = 19.99m, AuthorId = 1 },
            new Book { BookId = 2, Title = "The Book of Josie 2", PublishDate = new DateOnly(2022, 10, 12), BasePrice = 29.99m, AuthorId = 1 },
            new Book { BookId = 3, Title = "The Book of Jill", PublishDate = new DateOnly(2021, 10, 12), BasePrice = 19.99m, AuthorId = 2 },
            new Book { BookId = 4, Title = "The Book of Jill 2", PublishDate = new DateOnly(2022, 10, 12), BasePrice = 29.99m, AuthorId = 2 },
            new Book { BookId = 5, Title = "The Book of Jack", PublishDate = new DateOnly(2021, 10, 12), BasePrice = 19.99m, AuthorId = 3 },
            new Book { BookId = 6, Title = "The Book of Jack 2", PublishDate = new DateOnly(2022, 10, 12), BasePrice = 29.99m, AuthorId = 3 }
            );
    }
}
