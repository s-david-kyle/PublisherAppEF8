using Microsoft.EntityFrameworkCore;
using PublisherDomain;

namespace PublisherData;

public partial class PubContext : DbContext
{

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Author>().HasData(
            new Author { AuthorId = 1, FirstName = "Josie", LastName = "Newf" },
            new Author { AuthorId = 2, FirstName = "Jill", LastName = "Hill" },
            new Author { AuthorId = 3, FirstName = "Jack", LastName = "Black" },
            new Author { AuthorId = 4, FirstName = "Jen", LastName = "Ken" },
            new Author { AuthorId = 5, FirstName = "Jennifer", LastName = "Kensington" },
            new Author { AuthorId = 6, FirstName = "Sam", LastName = "Rami" }
            );
        modelBuilder.Entity<Book>().HasData(
            new Book { BookId = 1, Title = "The Book of Josie", PublishDate = new DateOnly(2021, 10, 12), BasePrice = 19.99m, AuthorId = 1 },
            new Book { BookId = 2, Title = "The Book of Josie 2", PublishDate = new DateOnly(2022, 10, 12), BasePrice = 29.99m, AuthorId = 1 },
            new Book { BookId = 3, Title = "The Book of Jill", PublishDate = new DateOnly(2021, 10, 12), BasePrice = 19.99m, AuthorId = 2 },
            new Book { BookId = 4, Title = "The Book of Jill 2", PublishDate = new DateOnly(2022, 10, 12), BasePrice = 29.99m, AuthorId = 2 },
            new Book { BookId = 5, Title = "The Book of Jack", PublishDate = new DateOnly(2021, 10, 12), BasePrice = 19.99m, AuthorId = 3 },
            new Book { BookId = 6, Title = "The Book of Jack 2", PublishDate = new DateOnly(2022, 10, 12), BasePrice = 29.99m, AuthorId = 3 },
            new Book { BookId = 7, Title = "The Book of Sam", PublishDate = new DateOnly(2022, 10, 12), BasePrice = 29.99m, AuthorId = 6 }
            );

        var someArtists = new Artist[]{
            new Artist {ArtistId = 1, FirstName = "Pablo", LastName="Picasso"},
            new Artist {ArtistId = 2, FirstName = "Dee", LastName="Bell"},
            new Artist {ArtistId = 3, FirstName ="Katharine", LastName="Kuharic"} };
        modelBuilder.Entity<Artist>().HasData(someArtists);

        var someCovers = new Cover[]{
            new Cover {CoverId = 1, BookId=3, DesignIdeas="How about a left hand in the dark?", DigitalOnly=false},
            new Cover {CoverId = 2, BookId=2, DesignIdeas= "Should we put a clock?", DigitalOnly=true},
            new Cover {CoverId = 3, BookId=1, DesignIdeas="A big ear in the clouds?", DigitalOnly = false}};
        modelBuilder.Entity<Cover>().HasData(someCovers);
    }
}
