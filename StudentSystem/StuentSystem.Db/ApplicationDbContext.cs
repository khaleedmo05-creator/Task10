using Microsoft.EntityFrameworkCore;
using StudentSystem.StudentSystem.models;
using System;
using System.Collections.Generic;
using System.Text;

namespace StudentSystem.StuentSystem.Db
{
    internal class ApplicationDbContext : DbContext
    {
        public DbSet<Student> Students { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Data Source=.; Initial Catalog=EfProject1; Integrated Security=True;Connect Timeout=30;Encrypt=True;Trust Server Certificate=True;");
        }
    }
}
