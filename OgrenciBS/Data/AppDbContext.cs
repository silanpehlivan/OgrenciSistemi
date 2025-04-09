using Microsoft.EntityFrameworkCore;
using OgrenciBS.Models;
using System.Collections.Generic;

namespace OBS.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> opt) : base(opt)
        {
        }

        public DbSet<Student> Student { get; set; }
        public DbSet<Department> Department { get; set; }
    }
}