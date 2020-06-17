using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ModelBinding.Models
{
    public static class EmployeeRepo
    {
        public static List<Employee> EmployeeList = new List<Employee>()
        {
            new Employee(1, "Bob"),
            new Employee(2, "Sue"),
            new Employee(3, "Mary")
        };
    }
}
