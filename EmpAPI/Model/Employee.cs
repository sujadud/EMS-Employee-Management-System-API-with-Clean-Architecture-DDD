using EmpAPI.Data.Interface;
using System.ComponentModel.DataAnnotations;

namespace EmpAPI.Model
{
    public class Employee : IId
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; } = string.Empty;
        [Required]
        [Display(Name = "Employee Code")]
        public string Code { get; set; } = string.Empty;
        public double Salary { get; set; }

        public virtual ICollection<EmployeeAttendance>? Attendances { get; set; }
    }
}
