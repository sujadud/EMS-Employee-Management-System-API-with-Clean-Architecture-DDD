using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Emp.Domain.ValueObjects
{
    public class EmployeeCode
    {
        public string Value { get; private set; }
        public EmployeeCode(string value)
        {
            if (string.IsNullOrEmpty(value)) throw new ArgumentNullException();
            Value = value;
        }
    }
}
