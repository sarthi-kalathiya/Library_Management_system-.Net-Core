using LibraryMGMT.Models;
namespace LibraryMGMT.Interfaces
{
    public interface IStudent
    {
        //get-students
        public  Task<List<Student>> Index();
    }
}
