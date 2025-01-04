using System.ComponentModel.DataAnnotations;

namespace Emp.Domain.Entities
{
    public class Attendance
    {
        [Key]
        public Guid Id { get; private set; }
        [Required]
        public Guid EmployeeId { get; private set; }
        public DateTime Date { get; private set; }
        public AttendanceStatus Status { get; private set; }

        public virtual Employee Employees { get; private set; }

        public Attendance(Guid employeeId, DateTime date, AttendanceStatus status)
        {
            EmployeeId = employeeId;
            Date = date;
            Status = status;
        }

        public enum AttendanceStatus
        {
            Present,
            Absent,
            Offday
        }
    }
}
