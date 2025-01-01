using System.ComponentModel.DataAnnotations;

namespace EmpAPI.ViewModel
{
    public class AttendenceReportVM
    {
        [Display(Name = "Employee Id")]
        public int Id { get; set; }
        [Display(Name = "Employee Name")]
        public string Name { get; set; } = string.Empty;
        [Display(Name = "Month Name")]
        public string Month { get; set; } = string.Empty;
        [Display(Name = "Total Present")]
        public int TotalPresent { get; set; }
        [Display(Name = "Total Absent")]
        public int TotalAbsent { get; set; }
        [Display(Name = "Total Offday")]
        public int TotalOffday { get; set; }
    }
}
