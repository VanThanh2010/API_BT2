﻿using Microsoft.EntityFrameworkCore;

namespace API_BT2.Models
{
    public class StudentCourses
    {
        public Student? Student { get; set; }
        public Guid? StudentId { get; set; }
        public Courses? Courses { get; set; }
        public Guid? CoursesId { get; set; }
    }
}
