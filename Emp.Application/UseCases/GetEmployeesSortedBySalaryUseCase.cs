using Emp.Application.DTOs;
using Emp.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Emp.Application.UseCases
{
    public class GetEmployeesSortedBySalaryUseCase
    {
        private readonly IEmployeeRepository _employeeRepository;

        public GetEmployeesSortedBySalaryUseCase(IEmployeeRepository employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }

        public async Task<IEnumerable<EmployeeDTO>> Execute()
        {
            var employees = await _employeeRepository.GetAllSortedBySalaryAsync();
            return employees.Select(e => new EmployeeDTO
            {
                Id = e.Id,
                Name = e.Name,
                EmployeeCode = e.EmployeeCode,
                Salary = e.Salary
            });
        }
    }
}
