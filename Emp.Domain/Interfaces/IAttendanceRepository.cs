using Emp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Emp.Domain.Interfaces
{
    public interface IAttendanceRepository
    {
        Task<IEnumerable<Attendance>> GetByEmployeeIdAsync(Guid employeeId);
        Task<IEnumerable<Employee>> GetAbsentEmployeesAsync();
        Task<IEnumerable<Attendance>> GetAttendanceReportAsync(DateTime startDate, DateTime endDate);
    }
}
