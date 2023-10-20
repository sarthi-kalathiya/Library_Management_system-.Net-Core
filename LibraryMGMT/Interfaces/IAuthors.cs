using LibraryMGMT.Models;

namespace LibraryMGMT.Interfaces
{
    public interface IAuthors
    {
        public Task<List<Author>> Index();
    }
}
