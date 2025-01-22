using Microsoft.EntityFrameworkCore;
using StudentListMVC.Models;

namespace StudentListMVC.Data
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Student> Students { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }
    }
}
