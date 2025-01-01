using System.ComponentModel.DataAnnotations;

namespace EmpAPI.ViewModel
{
    public class EmployeeVM
    {
        [Display(Name = "Employee Id")]
        public int Id { get; set; }
        [Display(Name = "Employee Name")]
        public string Name { get; set; } = string.Empty;
        [Display(Name = "Employee Code")]
        public string Code { get; set; } = string.Empty;
        public double Salary { get; set; }        
        [DataType(DataType.Date)]
        [Display(Name = "Attendance Date")]
        public DateTime Date { get; set; }
        public bool IsPresent { get; set; } = false;        
        public bool IsAbsent { get; set; } = false;
        public bool IsOffday { get; set; } = false;
    }
}
