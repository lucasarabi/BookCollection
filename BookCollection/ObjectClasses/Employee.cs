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
        public required string EmployeeID { get; set; }
        public required string Name { get; set; }
        public required decimal pay { get; set; }
        public required DateTime Birthday { get; set; }
        public int age => DateTime.Now.Year - Birthday.Year;

        public string DUMMY_USER = "username";
        public string DUMMY_PASS = "password";

        public Employee() { }

        [SetsRequiredMembers]
        public Employee(string ID, string Name, decimal salary, DateTime DOB)
        {
            this.EmployeeID = ID;
            this.Name = Name;
            this.pay = salary;
            this.Birthday = DOB;
        }
    }
}
