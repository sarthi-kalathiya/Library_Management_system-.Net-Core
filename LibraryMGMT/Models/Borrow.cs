using LibraryMGMT.Interfaces;

namespace LibraryMGMT.Models
{
    public class Borrow
    {
        public int BorrowId { get; set; }

        public int StudentId { get; set; }

        public int BookId { get; set; }

        public DateTime TakenDate { get; set; }

        public DateTime BroughtDate { get; set; }

        public virtual Book Book { get; set; } = null!;

        public virtual Student Student { get; set; } = null!;
    }
}
