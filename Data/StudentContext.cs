using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BackEndDeveloperAssessment.Models;
using Microsoft.EntityFrameworkCore;

namespace BackEndDeveloperAssessment.Data
{
    public class StudentContext : DbContext
    {
        public StudentContext(DbContextOptions<StudentContext> options) : base(options)
        {
        }

        public DbSet<Student> Students { get; set; }
        public DbSet<School> Schools { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Student>().ToTable("Student");
            modelBuilder.Entity<School>().ToTable("School");
        }
    }
}
