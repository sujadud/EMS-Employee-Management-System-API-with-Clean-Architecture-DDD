using Emp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Emp.Domain.Interfaces
{
    public interface IEmployeeRepository
    {
        Task<Employee> GetByIdAsync(Guid id);
        Task<Employee> GetByEmployeeCodeAsync(string code);
        Task<IEnumerable<Employee>> GetAllSortedBySalaryAsync();
        Task AddAsync(Employee employee);
        Task UpdateAsync(Employee employee);
    }
}
