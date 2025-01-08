using Emp.Application.UseCases;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EMS.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly GetEmployeesSortedBySalaryUseCase _getSortedBySalaryUseCase;
        private readonly UpdateEmployeeCodeUseCase  _updateEmployeeCodeUseCase;

        public EmployeeController(GetEmployeesSortedBySalaryUseCase getSortedBySalaryUseCase, UpdateEmployeeCodeUseCase updateEmployeeCodeUseCase)
        {
            _getSortedBySalaryUseCase = getSortedBySalaryUseCase;
            _updateEmployeeCodeUseCase = updateEmployeeCodeUseCase;
        }

        [HttpGet("salary")]
        public async Task<IActionResult> GetEmployeesBySalary()
        {
            var result = await _getSortedBySalaryUseCase.Execute();
            return Ok(result);
        }

        [HttpPut("{id}/code")]
        public async Task<IActionResult> UpdateEmployeeCode(Guid id, [FromBody] string newCode)
        {
            await _updateEmployeeCodeUseCase.Execute(id, newCode);
            return NoContent();
        }
    }
}
