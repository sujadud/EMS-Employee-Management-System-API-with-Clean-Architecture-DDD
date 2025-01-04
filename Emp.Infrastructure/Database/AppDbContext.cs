using Emp.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using static Emp.Domain.Entities.Attendance;

namespace Emp.Infrastructure.Database
{
    public class AppDbContext : DbContext
    {
        public AppDbContext()
        {
        }

        public AppDbContext(DbContextOptions options) : base(options) { }

        public DbSet<Employee> Employees { get; set; }
        public DbSet<Attendance> Attendances { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Fluent API config
            modelBuilder.Entity<Employee>(entity =>
            {
                entity.HasKey(e => e.Id); // Primary Key
                entity.Property(e => e.Name).IsRequired().HasMaxLength(100);
                entity.Property(e => e.EmployeeCode).IsRequired().HasMaxLength(10);
                entity.HasIndex(e => e.EmployeeCode).IsUnique(); // Unique
            });

            modelBuilder.Entity<Attendance>(entity =>
            {
                entity.HasKey(a => a.Id); // Primary key
                entity.Property(a => a.Date).IsRequired();
                entity.Property(a => a.Status).IsRequired();

                // Foreign Key - One 2 many relationship
                entity.HasOne(a => a.Employees)
                      .WithMany(e => e.Attendances)
                      .HasForeignKey(a => a.EmployeeId)
                      .OnDelete(DeleteBehavior.Cascade);
            });

            //// Seed Data
            var employee1Id = Guid.NewGuid();
            var employee2Id = Guid.NewGuid();

            modelBuilder.Entity<Employee>().HasData(
                new Employee(employee1Id, "Md. Sujad-ud Doula", "E001", 35000.00m),
                new Employee(employee2Id, "John Doe", "E002", 50000.00m)
            );

            modelBuilder.Entity<Attendance>().HasData(
                // Attendance for Md. Sujad-ud Doula
                new Attendance(Guid.NewGuid(), employee1Id, DateTime.Now.AddDays(-2), AttendanceStatus.Present),
                new Attendance(Guid.NewGuid(), employee1Id, DateTime.Now.AddDays(-4), AttendanceStatus.Present),
                new Attendance(Guid.NewGuid(), employee1Id, DateTime.Now.AddDays(-3), AttendanceStatus.Present),
                new Attendance(Guid.NewGuid(), employee1Id, DateTime.Now.AddDays(-1), AttendanceStatus.Offday),
                new Attendance(Guid.NewGuid(), employee1Id, DateTime.Now, AttendanceStatus.Absent),

                // Attendance for John Doe
                new Attendance(Guid.NewGuid(), employee2Id, DateTime.Now.AddDays(-2), AttendanceStatus.Present),
                new Attendance(Guid.NewGuid(), employee2Id, DateTime.Now.AddDays(-4), AttendanceStatus.Absent),
                new Attendance(Guid.NewGuid(), employee2Id, DateTime.Now.AddDays(-3), AttendanceStatus.Present),
                new Attendance(Guid.NewGuid(), employee2Id, DateTime.Now.AddDays(-1), AttendanceStatus.Offday),
                new Attendance(Guid.NewGuid(), employee2Id, DateTime.Now, AttendanceStatus.Absent)
            );
        }
    }
}
