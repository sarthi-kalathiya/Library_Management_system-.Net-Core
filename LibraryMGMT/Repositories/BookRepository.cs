using LibraryMGMT.Data;
using LibraryMGMT.Interfaces;
using LibraryMGMT.Models;
using Microsoft.EntityFrameworkCore;

namespace LibraryMGMT.Repositories
{
    public class BookRepository : IBooks
    {

        private readonly LibraryDbContext _context;

        public BookRepository(LibraryDbContext context)
        {
            _context = context;
        }
        //implementing using DbContext for GET-METHOD
        public async Task<List<Book>> Index()
        {
            var libraryDbContext = _context.Books.Include(b => b.Author);
            return (await libraryDbContext.ToListAsync());
        }
    }
}
