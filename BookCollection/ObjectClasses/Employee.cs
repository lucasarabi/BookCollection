using System;
using System.Collections.Generic;
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
    } 
}
