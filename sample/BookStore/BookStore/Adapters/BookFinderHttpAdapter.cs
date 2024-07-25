using System.Text.Json;
using BookStore.Exceptions;
using BookStore.Models;

namespace BookStore.Adapters;

public class BookFinderHttpAdapter(IHttpClientFactory httpClientFactory) : IBookFinderAdapter
{
    private readonly HttpClient _bookStoreClient = httpClientFactory.CreateClient("bookStore");

    public async Task<List<BookDto>> FindBooksAsync(string bookNameKeyword)
    {

        _bookStoreClient.DefaultRequestHeaders.TryAddWithoutValidation("bmw-sample", "true");
        _bookStoreClient.DefaultRequestHeaders.TryAddWithoutValidation("x-api-key", "1qaz@wsx");
        var response = await _bookStoreClient.GetAsync($"http://bookstore-e2e.sample.com/books/search/{bookNameKeyword}");
        var content = await response.Content.ReadAsStringAsync();
        if (response.IsSuccessStatusCode)
        {
            return JsonSerializer.Deserialize<List<BookDto>>(content) ?? new List<BookDto>();
        }
        else
        {
            throw new RemoteServiceException(nameof(FindBooksAsync), (int)response.StatusCode, content);
        }
    }

    public async Task<BookDto?> GetBookAsync(Guid id)
    {
        _bookStoreClient.DefaultRequestHeaders.TryAddWithoutValidation("bmw-sample", "true");
        _bookStoreClient.DefaultRequestHeaders.TryAddWithoutValidation("x-api-key", "1qaz@wsx");
        var response = await _bookStoreClient.GetAsync($"http://bookstore-e2e.sample.com/books/{id}");
        var content = await response.Content.ReadAsStringAsync();
        if (response.IsSuccessStatusCode)
        {
            return JsonSerializer.Deserialize<BookDto>(content);
        }
        else
        {
            throw new RemoteServiceException(nameof(GetBookAsync), (int)response.StatusCode, content);
        }
    }
}