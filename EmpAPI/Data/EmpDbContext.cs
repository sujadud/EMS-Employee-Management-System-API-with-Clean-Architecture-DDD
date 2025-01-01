using EmpAPI.Model;
using Microsoft.EntityFrameworkCore;

namespace EmpAPI.Data
{
    public class EmpDbContext : DbContext
    {
        public EmpDbContext()
        {
        }

        public EmpDbContext(DbContextOptions options) : base(options)
        {   
        }

        public virtual DbSet<Employee> Employees { get; set; }
        public virtual DbSet<EmployeeAttendance> EmpAttendances { get; set; }
    }
}
