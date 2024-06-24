using Microsoft.EntityFrameworkCore;
using PublisherData;
using PublisherDomain;

using (PubContext context = new())
{
    context.Database.EnsureCreated();
}

//GetAuthors();
//AddAuthor();
//GetAuthors();
AddAuthorWithBook();
GetAuthorsWithBooks();

void AddAuthorWithBook()
{
    var author = new Author { FirstName = "Josie", LastName = "Newf" };
    author.Books.Add(new Book { Title = "The Book of Josie", PublishDate = new DateOnly(2021, 10, 12), BasePrice = 19.99m });
    author.Books.Add(new Book { Title = "The Book of Josie 2", PublishDate = new DateOnly(2022, 10, 12), BasePrice = 29.99m });
    using PubContext context = new();
    context.Authors.Add(author);
    context.SaveChanges();
}

void GetAuthorsWithBooks()
{
    using PubContext context = new();
    var authors = context.Authors.Include(a => a.Books).ToList();
    foreach (var author in authors)
    {
        Console.WriteLine($"{author.FirstName} {author.LastName}");
        foreach (var book in author.Books)
        {
            Console.WriteLine($"\t{book.Title} {book.PublishDate} {book.BasePrice}");
        }
    }
}

void AddAuthor()
{
    using PubContext context = new();
    var author = new Author { FirstName = "Josie", LastName = "Newf" };
    context.Authors.Add(author);
    context.SaveChanges();
}
void GetAuthors()
{
    using PubContext context = new();
    var authors = context.Authors.ToList();
    foreach (var author in authors)
    {
        Console.WriteLine($"{author.FirstName} {author.LastName}");
    }
}