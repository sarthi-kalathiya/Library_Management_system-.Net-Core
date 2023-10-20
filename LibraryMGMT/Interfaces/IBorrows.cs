using LibraryMGMT.Models;
namespace LibraryMGMT.Interfaces
{
    public interface IBorrows
    {
        //get-borrow details
        public Task<List<Borrow>> Index();
    }
}
