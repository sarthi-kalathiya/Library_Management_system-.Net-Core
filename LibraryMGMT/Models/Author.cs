namespace LibraryMGMT.Models
{
    public class Author
    {
        public int AuthorId { get; set; }

        public string Name { get; set; } = null!;

        public virtual ICollection<Book> Books { get; } = new List<Book>();
    }
}
