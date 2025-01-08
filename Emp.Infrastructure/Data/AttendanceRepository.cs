using Emp.Domain.Entities;
using Emp.Domain.Interfaces;
using Emp.Infrastructure.Database;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Emp.Domain.Entities.Attendance;

namespace Emp.Infrastructure.Data
{
    public class AttendanceRepository : IAttendanceRepository
    {
        private readonly AppDbContext _context;

        public AttendanceRepository(AppDbContext context)
        {
            _context = context;
        }
        public async Task<IEnumerable<Attendance>> GetByEmployeeIdAsync(Guid employeeId) =>
            await _context.Attendances.Where(a => a.EmployeeId == employeeId).ToListAsync();

        public async Task<IEnumerable<Employee>> GetAbsentEmployeesAsync() => 
            await _context.Employees.Where(e => 
                _context.Attendances.Any(a => a.EmployeeId == e.Id && a.Status == AttendanceStatus.Absent)).ToListAsync();

        public async Task<IEnumerable<Attendance>> GetAttendanceReportAsync(DateTime startDate, DateTime endDate) =>
            await _context.Attendances.Include(a => a.Employee).Where(a => a.Date >= startDate && a.Date <= endDate).ToListAsync();
    }
}
