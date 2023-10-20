using LibraryMGMT.Models;
namespace LibraryMGMT.Interfaces
{
    public interface IBooks
    {
        //get-books
        public Task<List<Book>> Index();
    }
}
