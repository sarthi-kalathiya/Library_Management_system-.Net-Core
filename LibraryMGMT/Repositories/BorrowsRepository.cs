using LibraryMGMT.Data;
using LibraryMGMT.Interfaces;
using LibraryMGMT.Models;
using Microsoft.EntityFrameworkCore;
namespace LibraryMGMT.Repositories
{
    public class BorrowsRepository : IBorrows
    {
        private readonly LibraryDbContext _context;

        public BorrowsRepository(LibraryDbContext context)
        {
            _context = context;
        }
        //implementing using DbContext for GET-METHOD
        public async Task<List<Borrow>> Index()
        {
            var libraryDbContext = _context.Borrows.Include(b => b.Book).Include(b => b.Student);
            return (await libraryDbContext.ToListAsync());
        }
    }
}
