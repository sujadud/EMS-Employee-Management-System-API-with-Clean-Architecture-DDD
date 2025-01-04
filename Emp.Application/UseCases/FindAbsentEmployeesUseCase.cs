using Emp.Application.DTOs;
using Emp.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Emp.Application.UseCases
{
    public class FindAbsentEmployeesUseCase
    {
        private readonly IAttendanceRepository _attendanceRepository;

        public FindAbsentEmployeesUseCase(IAttendanceRepository attendanceRepository)
        {
            _attendanceRepository = attendanceRepository;
        }

        public async Task<IEnumerable<EmployeeDTO>> Execute()
        {
            var employees = await _attendanceRepository.GetAbsentEmployeesAsync();
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
