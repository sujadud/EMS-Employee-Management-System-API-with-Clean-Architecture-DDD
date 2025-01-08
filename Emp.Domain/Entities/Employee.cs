using System.ComponentModel.DataAnnotations;

namespace Emp.Domain.Entities
{
    public class Employee
    {
        [Key]
        public Guid Id { get; private set; }
        public string Name { get; private set; }
        public string EmployeeCode { get; private set; }
        public decimal Salary { get; private set; }

        public ICollection<Attendance> Attendances { get; set; }

        public Employee() { }

        public Employee(Guid id, string name, string employeeCode, decimal salary)
        {
            Id = id;
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
