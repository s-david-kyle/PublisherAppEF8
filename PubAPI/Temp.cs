using Microsoft.AspNetCore.Http.HttpResults;
using PublisherData;

namespace PubAPI;

public class Temp
{
    PubContext _context;

    public Temp(PubContext context)
    {
        _context = context;
    }

    public async Task<Results<Ok, NotFound>> GetAuthor(int authorid)
    {
        var author = await _context.Authors.FindAsync(authorid);
        return author is not null ? TypedResults.Ok() : TypedResults.NotFound();
    }
}
