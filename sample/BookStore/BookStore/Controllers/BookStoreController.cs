using BookStore.Exceptions;
using BookStore.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using static Microsoft.Extensions.Logging.EventSource.LoggingEventSource;

namespace BookStore.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class BookStoreController : ControllerBase
    {
        private readonly IBookStoreAppService _bookStoreAppService;
        private readonly ILogger<BookStoreController> _logger;

        public BookStoreController(IBookStoreAppService bookStoreAppService, ILogger<BookStoreController> logger)
        {
            _bookStoreAppService = bookStoreAppService;
            _logger = logger;
        }

        [HttpGet]
        [Route("search/{keyword}")]
        public async Task<IActionResult> FindBook(string keyword)
        {

            var books = await _bookStoreAppService.FindBooksAsync(keyword);
            return Ok(books);
        }

        [HttpGet]
        [Route("{id:guid}")]
        public async Task<IActionResult> FindBook(Guid id)
        {

            var books = await _bookStoreAppService.GetBookAsync(id);
            return Ok(books);
        }
    }
}
