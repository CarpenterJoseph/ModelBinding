using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ModelBinding.Models
{
    public class Employee
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public Employee(int ID, string Name)
        {
            this.ID = ID;
            this.Name = Name;
        }
    }
}
