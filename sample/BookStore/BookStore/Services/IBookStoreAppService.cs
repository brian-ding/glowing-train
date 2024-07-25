using BookStore.Models;

namespace BookStore.Services;

public interface IBookStoreAppService
{
    Task<List<BookDto>> FindBooksAsync(string bookNameKeyword);

    Task<BookDto?> GetBookAsync(Guid id);
}