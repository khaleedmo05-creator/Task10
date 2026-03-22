using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace StudentSystem.StudentSystem.models
{
    internal class Student
    {
        public int Id { get; set; }
        [Column(TypeName = "varchar(100)")]
        [Unicode(false)]
        public string Name { get; set; }
        [Column(TypeName = "varchar(10)")]
        public string PhoneNumber { get; set; }
        public DateTime RegisteredOn { get; set; }
        public DateTime? Birthday { get; set; }
        public ICollection<StudentCourse> StudentCourses { get; set; }
        public ICollection<Homework> Homeworks { get; set; }
    }
}
