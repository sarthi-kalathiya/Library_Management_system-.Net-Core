using LibraryMGMT.Interfaces;
using LibraryMGMT.Models;
using LibraryMGMT.Data;
using Microsoft.EntityFrameworkCore;

namespace LibraryMGMT.Repositories
{
    public class AuthorsRepository : IAuthors
    {
        private readonly LibraryDbContext _context;

        public AuthorsRepository(LibraryDbContext context)
        {
            _context = context;
        }

        //implementing using DbContext for GET-METHOD
        public async Task<List<Author>> Index()
        {
            return (await _context.Authors.ToListAsync());
        }
    }
}
