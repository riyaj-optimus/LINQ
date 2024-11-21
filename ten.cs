using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq_Assignment
{
   

    public class Employeees
    {
        public int EmployeeID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Department { get; set; }
    }

    class ten
    {
        //static void Main()
        //{
           
        //    var employees = new List<Employeees>
        //{
        //    new Employeees { EmployeeID = 1, FirstName = "John", LastName = "Doe", Department = "HR" },
        //    new Employeees { EmployeeID = 2, FirstName = "Jane", LastName = "Smith", Department = "Finance" },
        //    new Employeees { EmployeeID = 3, FirstName = "Alice", LastName = "Johnson", Department = "HR" },
        //    new Employeees { EmployeeID = 4, FirstName = "Bob", LastName = "Brown", Department = "IT" },
        //    new Employeees { EmployeeID = 5, FirstName = "Charlie", LastName = "Davis", Department = "HR" }
        //};

        //    var res = employees.Where(s=>s.Department=="HR").Select(e => new {
        //    employeeID = e.EmployeeID,
        //    FullName = e.FirstName+ " "+e.LastName
        //    });

        //    foreach(var e in res)
        //    {
        //        Console.WriteLine($"empID : {e.employeeID}  FullName : {e.FullName}");
        //    }

        //}
    }

}
