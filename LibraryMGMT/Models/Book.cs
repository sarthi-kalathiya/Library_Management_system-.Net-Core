using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations; // Add this using directive

using LibraryMGMT.Interfaces;

namespace LibraryMGMT.Models
{
    public class Book
    {
        public int BookId { get; set; }

        [Required(ErrorMessage = "Name is required")]
        public string Name { get; set; }

        [Required(ErrorMessage = "PageCount is required")]
        public int? PageCount { get; set; }

        public int AuthorId { get; set; }

        public virtual Author Author { get; set; } = null!;

        public virtual ICollection<Borrow> Borrows { get; } = new List<Borrow>();
    }
}
