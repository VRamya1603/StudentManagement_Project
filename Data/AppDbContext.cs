using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using StudentManagement.Models;

namespace StudentSystem.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext (DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }

        public DbSet<StudentManagement.Models.Student> Student { get; set; } = default!;

        public DbSet<StudentManagement.Models.Staff> Staff { get; set; } = default!;

        public DbSet<StudentManagement.Models.Course> Course { get; set; } = default!;

        public DbSet<StudentManagement.Models.Classes> Classes { get; set; } = default!;
    }
}
