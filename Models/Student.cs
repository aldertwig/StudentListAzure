using System.ComponentModel;

namespace StudentListMVC.Models
{
    public class Student
    {
        public int Id { get; set; }

        [DisplayName("First Name")]
        public string? Firstname { get; set; }

        [DisplayName("Last Name")]
        public string? Lastname { get; set; }
    }
}
