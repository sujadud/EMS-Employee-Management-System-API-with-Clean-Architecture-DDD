namespace EMS.API.ViewModels
{
    public class AttendanceReportVM
    {
        public string EmployeeName { get; set; }
        public string MonthName { get; set; }
        public int TotalPresent { get; set; }
        public int TotalAbsent { get; set; }
        public int TotalOffDay { get; set; }
    }
}
