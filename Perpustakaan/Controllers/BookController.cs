using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Perpustakaan.Services.BookServices;

namespace Perpustakaan.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookController : ControllerBase
    {
        private readonly IBookServices _bookServices;
        public BookController(IBookServices bookServices)
        {
            _bookServices = bookServices;
        }

        [HttpGet]
        public async Task<ActionResult<List<BookClass>>> GetAllBook()
        {
            return _bookServices.GetAllBook();
        }

        [HttpGet("{Id}")]
        public async Task<ActionResult<BookClass>> GetSingleBook(int Id)
        {
            var result = _bookServices.GetSingleBook(Id);
            if (result is null)
            {
                return NotFound("Buku Tidak Tersedia!");
            }

            return Ok(result);
        }

        [HttpPost]
        public async Task<ActionResult<List<BookClass>>> AddBook(BookClass book)
        {
            var result = _bookServices.AddBook(book);
            return Ok(result);
        }

        [HttpPut("{Id}")]
        public async Task<ActionResult<List<BookClass>>> UpdateBook(int Id, BookClass request)
        {
            var result = _bookServices.UpdateBook(Id, request);
            if (result is null)
                return NotFound("Buku Tidak Tersedia!");

            return Ok(result);
        }

        [HttpDelete("{Id}")]
        public async Task<ActionResult<List<BookClass>>> DeleteBook(int Id)
        {
            var result = _bookServices.DeleteBook(Id);
            if (result is null)
                return NotFound("Buku Tidak Tersedia!");

            return Ok(result);
        }
    }
}
