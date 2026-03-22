using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace StudentSystem.StudentSystem.models
{
    internal class Course
    {
        public int Id { get; set; }
        [Column(TypeName = "varchar(100)")]
        [Unicode(false)]
        public string Name { get; set; }
        [Unicode(false)]
        public string Describtion { get; set; }
        public DateTime StartTme { get; set; }
        public DateTime EndTme { get; set; }
        public double Price { get; set; }
        public ICollection<Resource> Resources { get; set; }
        public ICollection<Homework> Homeworks { get; set; }
        public ICollection<StudentCourse> StudentCourses { get; set; }
    }
}
