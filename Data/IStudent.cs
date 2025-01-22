using StudentListMVC.Models;

namespace StudentListMVC.Data
{
    public interface IStudent
    {
        IEnumerable<Student> GetAll();
    }
}
