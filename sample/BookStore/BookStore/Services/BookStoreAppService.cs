using BookStore.Adapters;
using BookStore.Models;

namespace BookStore.Services;

public class BookStoreAppService(IBookFinderAdapter bookFinder) : IBookStoreAppService
{
    private static readonly List<string> IgnoreAuthor = ["A", "B", "AABB"];

    public async Task<List<BookDto>> FindBooksAsync(string bookNameKeyword)
    {

        var books = await bookFinder.FindBooksAsync(bookNameKeyword);
        books = books.Where(x => !IgnoreAuthor.Contains(x.Author.Name)).ToList();

        return books;
    }

    public Task<BookDto?> GetBookAsync(Guid id)
    {
        return bookFinder.GetBookAsync(id);
    }
}