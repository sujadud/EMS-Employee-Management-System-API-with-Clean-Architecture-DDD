using Emp.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Emp.Infrastructure.Database
{
    public class AppDbContext : DbContext
    {
        public AppDbContext()
        {
        }

        public AppDbContext(DbContextOptions options) : base(options)
        {   
        }

        public DbSet<Employee> Employees { get; set; }
        public DbSet<Attendance> Attendances { get; set; }
    }
}
