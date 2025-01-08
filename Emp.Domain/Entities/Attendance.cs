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

        public Employee Employee { get; private set; }

        public Attendance() { }

        public Attendance(Guid id, Guid employeeId, DateTime date, AttendanceStatus status)
        {
            Id = id;
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
