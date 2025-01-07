using Emp.Domain.Entities;
using Emp.Domain.Interfaces;
using Emp.Infrastructure.Database;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Emp.Infrastructure.Data
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private readonly AppDbContext _context;

        public EmployeeRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task<Employee> GetByIdAsync(Guid id) =>
            await _context.Employees.FindAsync(id);

        public async Task<Employee> GetByEmployeeCodeAsync(string code) =>
            await _context.Employees.FirstOrDefaultAsync(e => e.EmployeeCode == code);

        public async Task<IEnumerable<Employee>> GetAllSortedBySalaryAsync() =>
            await _context.Employees.OrderByDescending(e => e.Salary).ToListAsync();

        public async Task AddAsync(Employee employee) =>
            await _context.Employees.AddAsync(employee);

        public async Task UpdateAsync(Employee employee) =>
            _context.Employees.Update(employee).Context.SaveChanges();
    }
}
