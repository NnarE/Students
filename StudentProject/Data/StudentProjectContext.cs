using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using StudentProject.Models;
using System.Data.Entity;

namespace StudentProject.Models
{
    public class StudentProjectContext : DbContext
    {
        public StudentProjectContext(DbContextOptions<StudentProjectContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            // configures one-to-many relationship
            modelBuilder.Entity<Student>()
                .HasRequired<Grade>(s => s.CurrentGrade)
                .WithMany(g => g.Students)
                .HasForeignKey<int>(s => s.CurrentGradeId);
        }
        public DbSet<StudentProject.Models.Student> Student { get; set; }

        public DbSet<StudentProject.Models.Grade> Grade { get; set; }


    }


}

