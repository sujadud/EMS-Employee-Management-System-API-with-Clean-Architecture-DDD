using System.ComponentModel.DataAnnotations;

namespace Emp.Domain.Entities
{
    public class Employee
    {
        [Key]
        public Guid Id { get; private set; }
        public string Name { get; private set; } = string.Empty;
        public string EmployeeCode { get; private set; } = string.Empty;
        public decimal Salary { get; private set; }

        public Employee(string name, string employeeCode, decimal salary)
        {
            Name = name;
            EmployeeCode = employeeCode;
            Salary = salary;
        }

        public void UpdateEmployeeCode(string newCode)
        {
            if (string.IsNullOrEmpty(newCode)) throw new ArgumentNullException();
            EmployeeCode = newCode;
        }
    }
}
