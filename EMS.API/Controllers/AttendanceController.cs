using Emp.Application.UseCases;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EMS.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AttendanceController : ControllerBase
    {
        private readonly FindAbsentEmployeesUseCase _findAbsentUseCase;
        private readonly AttendanceReportUseCase _attendanceReportUseCase;

        public AttendanceController(FindAbsentEmployeesUseCase findAbsentUseCase, AttendanceReportUseCase attendanceReportUseCase)
        {
            _findAbsentUseCase = findAbsentUseCase;
            _attendanceReportUseCase = attendanceReportUseCase;
        }

        [HttpGet("absentEmployees")]
        public async Task<IActionResult> GetAbsentEmployees()
        {
            var result = await _findAbsentUseCase.Execute();
            return Ok(result);
        }

        [HttpGet("attendanceReport")]
        public async Task<IActionResult> GetAttendanceReport(DateTime startDate, DateTime endDate)
        {
            var result = await _attendanceReportUseCase.Execute(startDate, endDate);
            return Ok(result);
        }
    }
}
