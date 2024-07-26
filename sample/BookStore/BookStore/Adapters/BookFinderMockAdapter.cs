using BookStore.Models;

namespace BookStore.Adapters;

public class BookFinderMockAdapter : IBookFinderAdapter
{
    public Task<List<BookDto>> FindBooksAsync(string bookNameKeyword)
    {
        return Task.FromResult(new List<BookDto>()
        {
            new BookDto(Guid.NewGuid(), "F&Z",new Author("tim",""),new Publisher(Guid.NewGuid(), "Z",""),DateTime.UtcNow, 4.0f,new List<ReviewComment>())
        });
    }

    public Task<BookDto?> GetBookAsync(Guid id)
    {
        return Task.FromResult(new BookDto(Guid.NewGuid(), "F&Z", new Author("tim", ""), new Publisher(Guid.NewGuid(), "Z", ""), DateTime.UtcNow, 4.0f, new List<ReviewComment>()));
    }
}