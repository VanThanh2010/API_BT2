using System.ComponentModel.DataAnnotations;

namespace API_BT2.Models
{
    public class Student
    {
        [Key]
        public Guid? StudentId { get; set; }
        public string? Name { get; set; }
        public List<StudentCourses>? StudentCourses { get; set; }
    }
}
