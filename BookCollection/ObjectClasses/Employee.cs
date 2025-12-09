using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookCollection.ObjectClasses
{
    public class Employee
    {
        public int EmployeeID { get; set; }
        public required string Name { get; set; }
        public required decimal pay { get; set; }
        public required DateTime Birthday { get; set; }
        public int age => DateTime.Now.Year - Birthday.Year;

        public Employee() { }

        [SetsRequiredMembers]
        public Employee(string Name, decimal salary, DateTime DOB)
        {
            this.Name = Name;
            this.pay = salary;
            this.Birthday = DOB;
        }
    }
}
