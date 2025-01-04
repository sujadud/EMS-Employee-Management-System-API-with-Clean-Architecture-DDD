using Emp.Application.UseCases;
using Emp.Domain.Interfaces;
using Emp.Infrastructure.Data;
using Emp.Infrastructure.Database;
using Microsoft.EntityFrameworkCore;

namespace EMS.API
{
    public static class ServiceRegistration
    {
        public static void RegisterServices(this IServiceCollection services, string connectionString)
        {
            // Register DbContext (ensure you provide the correct connection string)
            services.AddDbContext<AppDbContext>(options =>
                options.UseSqlServer(connectionString, b => b.MigrationsAssembly("EMS.API")));

            // Register UseCases
            services.AddScoped<GetEmployeesSortedBySalaryUseCase>();
            services.AddScoped<UpdateEmployeeCodeUseCase>();
            services.AddScoped<AttendanceReportUseCase>();
            services.AddScoped<FindAbsentEmployeesUseCase>();

            // Add other application services or repositories if needed
            services.AddScoped<IEmployeeRepository, EmployeeRepository>();
            services.AddScoped<IAttendanceRepository, AttendanceRepository>();
        }
    }
}
