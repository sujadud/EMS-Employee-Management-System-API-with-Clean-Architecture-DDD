using Emp.Application.DTOs;
using Emp.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Emp.Domain.Entities.Attendance;

namespace Emp.Application.UseCases
{
    public class AttendanceReportUseCase
    {
        private readonly IAttendanceRepository _attendanceRepository;

        public AttendanceReportUseCase(IAttendanceRepository attendanceRepository)
        {
            _attendanceRepository = attendanceRepository;
        }

        public async Task<IEnumerable<AttendanceReportDTO>> Execute(DateTime startDate, DateTime endDate)
        {
            var attendanceRecords = await _attendanceRepository.GetAttendanceReportAsync(startDate, endDate);
            return attendanceRecords.GroupBy(a => a.EmployeeId).Select(group => new AttendanceReportDTO
            {
                EmployeeName = group.First().Employee.Name,
                MonthName = startDate.ToString("MMMM"),
                TotalPresent = group.Count(a => a.Status == AttendanceStatus.Present),
                TotalAbsent = group.Count(a => a.Status == AttendanceStatus.Absent),
                TotalOffday = group.Count(a => a.Status == AttendanceStatus.Offday)
            });
        }
    }
}
