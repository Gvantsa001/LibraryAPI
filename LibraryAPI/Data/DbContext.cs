using Microsoft.EntityFrameworkCore;
using LibraryAPI.Models;
public class BookstoreDbContext : DbContext
{

    public BookstoreDbContext(DbContextOptions<BookstoreDbContext> options) : base(options) { }

    public DbSet<Book> Books { get; set; }
    public object Authors { get; internal set; }
}
