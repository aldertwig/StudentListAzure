using StudentListMVC.Models;

namespace StudentListMVC.Data
{
    public class StudentRepository : IStudent
    {
        private readonly ApplicationDbContext _applicationDbContext;

        public StudentRepository(ApplicationDbContext applicationDbContext)
        {
            _applicationDbContext = applicationDbContext;
        }

        public IEnumerable<Student> GetAll()
        {
            return _applicationDbContext.Students.OrderBy(s => s.Lastname);
        }
    }
}
