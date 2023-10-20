using System.ComponentModel.DataAnnotations;

namespace LibraryMGMT.Models
{
    public class Student
    {
        public int StudentId { get; set; }

        [Required(ErrorMessage = "Name is required")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Gender is required")]
        public string Gender { get; set; }

        [Required(ErrorMessage = "Course is required")]
        public string Course { get; set; }

        public virtual ICollection<Borrow> Borrows { get; } = new List<Borrow>();
    }
}
