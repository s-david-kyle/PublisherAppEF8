using Microsoft.EntityFrameworkCore;
using PublisherData;


PubContext _context = new();

SimpleRawSQL();
void SimpleRawSQL()
{
    var authors = _context.Authors.FromSqlRaw("SELECT * FROM Authors")
        .Include(a => a.Books)
        .ToList();
    authors.ForEach(author =>
    {
        Console.WriteLine($"{author.FirstName} {author.LastName}")
        ; author.Books.ForEach(book =>
        {
            Console.WriteLine($"\t{book.Title} {book.PublishDate} {book.BasePrice}");

        });


    });
}


#region old code
//GetAnAuthorWithTheirBooksWithCoversWithArtists();
//void GetAnAuthorWithTheirBooksWithCoversWithArtists()
//{
//    var author = _context.Authors.AsNoTracking()
//        .Include(a => a.Books)
//        .ThenInclude(b => b.Cover)
//        .ThenInclude(c => c.Artists)
//        .FirstOrDefault(a => a.AuthorId == 1);

//    Console.WriteLine($"{author.FirstName} {author.LastName}");
//    author.Books.ForEach(book =>
//    {
//        Console.WriteLine($"\t{book.Title} {book.PublishDate} {book.BasePrice}");
//        Console.WriteLine($"\t\t{book.Cover.DesignIdeas}");
//        book.Cover.Artists.ForEach(artist =>
//        {
//            Console.WriteLine($"\t\t{artist.FirstName} {artist.LastName}");
//        });
//    });
//}




//GetAllBooksWithTheirCovers();
//void GetAllBooksWithTheirCovers()
//{
//    var booksWithCovers = _context.Books
//        .Include(b => b.Cover)
//        .ToList();
//    booksWithCovers.ForEach(book =>
//    {
//        Console.WriteLine($"{book.Title} {book.Cover.DesignIdeas}");
//    });

//}


//RetrieveAnArtistWithTheirCovers();

//void RetrieveAnArtistWithTheirCovers()
//{
//    var artistWithCovers = _context.Artists
//        .Include(a => a.Covers)
//        .FirstOrDefault(a => a.ArtistId == 1);
//}





//ConnecNewArtistAndCoverObjects();
//void ConnecNewArtistAndCoverObjects()
//{
//    var newArtist = new Artist { FirstName = "Kir", LastName = "Talmage" };
//    var newCover = new Cover { DesignIdeas = "We like birds!", DigitalOnly = false };
//    newCover.Artists.Add(newArtist);
//    _context.Covers.Add(newCover);
//    _context.SaveChanges();
//}




//ConnectExistingArtistAndCoverObjects();
//void ConnectExistingArtistAndCoverObjects()
//{
//    using PubContext _context = new();

//    var artistA = _context.Artists.Find(1);
//    var artistB = _context.Artists.Find(2);
//    var coverA = new Cover { DesignIdeas = "Author has provided a cover", DigitalOnly = false };
//    coverA.Artists.Add(artistA);
//    coverA.Artists.Add(artistB);
//    _context.Covers.Add(coverA);
//    _context.SaveChanges();
//}





//EagerLoadingBooksWithAuthors();

//void EagerLoadingBooksWithAuthors()
//{
//    using PubContext context = new();
//    //var authors = context.Authors
//    //    .Include(a => a.Books).ToList();

//    var pubStartDate = new DateOnly(2020, 1, 1);

//    var authors = context.Authors
//        .Include(a => a.Books
//            .Where(b => b.PublishDate >= pubStartDate)
//            .OrderBy(b => b.Title))
//        .ToList();

//    authors.ForEach(author =>
//    {
//        Console.WriteLine($"{author.FirstName} {author.LastName}");
//        author.Books.ForEach(book =>
//        {
//            Console.WriteLine($"\t{book.Title} {book.PublishDate} {book.BasePrice}");
//        });
//    });
//}


//GetAuthors();

//void GetAuthors()
//{
//    using PubContext context = new();
//    var authors = context.Authors.ToList();

//foreach (var author in authors)
//{
//    Console.WriteLine($"{author.FirstName} {author.LastName}");
//}
//}


//using (PubContext context = new())
//{
//    context.Database.EnsureCreated();
//}
//AddAuthor();
//GetAuthors();
//AddAuthorWithBook();
//GetAuthorsWithBooks();

//void AddAuthorWithBook()
//{
//    var author = new Author { FirstName = "Josie", LastName = "Newf" };
//    author.Books.Add(new Book { Title = "The Book of Josie", PublishDate = new DateOnly(2021, 10, 12), BasePrice = 19.99m });
//    author.Books.Add(new Book { Title = "The Book of Josie 2", PublishDate = new DateOnly(2022, 10, 12), BasePrice = 29.99m });
//    using PubContext context = new();
//    context.Authors.Add(author);
//    context.SaveChanges();
//}

//void GetAuthorsWithBooks()
//{
//    using PubContext context = new();
//    var authors = context.Authors.Include(a => a.Books).ToList();
//    foreach (var author in authors)
//    {
//        Console.WriteLine($"{author.FirstName} {author.LastName}");
//        foreach (var book in author.Books)
//        {
//            Console.WriteLine($"\t{book.Title} {book.PublishDate} {book.BasePrice}");
//        }
//    }
//}

//void AddAuthor()
//{
//    using PubContext context = new();
//    var author = new Author { FirstName = "Josie", LastName = "Newf" };
//    context.Authors.Add(author);
//    context.SaveChanges();
//}
#endregion
