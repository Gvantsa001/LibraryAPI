using LibraryAPI.Data;
using LibraryAPI.Dtos;
using LibraryAPI.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace LibraryAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class BooksController : ControllerBase
    {
        private readonly BookstoreDbContext _context;

        public BooksController(BookstoreDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<BookDto>>> GetBooks()
        {
            var books = await _context.Books
                .Include(b => b.Author)
                .Select(b => new BookDto
                {
                    Id = b.Id,
                    Title = b.Title,
                    YearOfPublication = b.YearOfPublication
                }).ToListAsync();

            return Ok(books);
        }

        [HttpPost]
        public async Task<IActionResult> CreateBook(CreateBookDto dto)
        {
            var book = new Book
            {
                Title = dto.Title,
                YearOfPublication = dto.YearOfPublication,
                AuthorId = dto.AuthorId
            };

            _context.Books.Add(book);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetBooks), new { id = book.Id }, book);
        }
    }
}
