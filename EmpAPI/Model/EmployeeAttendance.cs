using EmpAPI.Data.Interface;
using System.ComponentModel.DataAnnotations;

namespace EmpAPI.Model
{
    public class EmployeeAttendance : IId
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public int EmployeeId { get; set; }
        [Required]
        [DataType(DataType.DateTime)]
        [Display(Name = "Attendance Date")]
        public DateTime Date { get; set; }
        [Required]
        public bool IsPresent { get; set; }
        [Required]
        public bool IsAbsent { get; set; }
        [Required]
        public bool IsOffday { get; set; }

        public virtual required Employee Employee { get; set; }
    }
}
