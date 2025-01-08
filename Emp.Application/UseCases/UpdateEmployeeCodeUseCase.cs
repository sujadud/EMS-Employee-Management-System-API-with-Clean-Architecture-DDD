using Emp.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Emp.Application.UseCases
{
    public class UpdateEmployeeCodeUseCase
    {
        private readonly IEmployeeRepository _employeeRepository;

        public UpdateEmployeeCodeUseCase(IEmployeeRepository employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }

        public async Task Execute(Guid empId, string newCode)
        {
            var existingEmp = await _employeeRepository.GetByEmployeeCodeAsync(newCode);
            if (existingEmp != null)
                throw new Exception("Employee code must be unique.");

            var emp = await _employeeRepository.GetByIdAsync(empId);
            emp.UpdateEmployeeCode(newCode);
            await _employeeRepository.UpdateAsync(emp);
        }
    }
}
