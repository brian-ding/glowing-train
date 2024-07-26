using BookStore.Models;

namespace BookStore.Adapters;

public interface IBookFinderAdapter
{
    Task<List<BookDto>> FindBooksAsync(string bookNameKeyword);

    Task<BookDto?> GetBookAsync(Guid id);

}