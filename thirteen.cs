using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq_Assignment
{

    public class Students
    {
        public int StudentID { get; set; }
        public string Name { get; set; }
        public List<int> Grades { get; set; }
    }

    class thirteen
    {
        //static void Main()
        //{
           
        //    var students = new List<Students>
        //{
        //    new Students { StudentID = 1, Name = "Alice", Grades = new List<int> { 60, 70, 80 } },
        //    new Students { StudentID = 2, Name = "Bob", Grades = new List<int> { 50, 55, 65 } },
        //    new Students { StudentID = 3, Name = "Charlie", Grades = new List<int> { 45, 70, 80 } },
        //    new Students { StudentID = 4, Name = "Diana", Grades = new List<int> { 90, 88, 76 } }
        //};
        //    var res = students.Where(s => s.Grades.All(n => n > 50));

        //    foreach(var i in res)
        //    {
        //        Console.WriteLine("Student name : " + i.Name);
        //    }
        //    //boolean value to store if each student passed or failed

        //    var resu = students.Where(s => s.Grades.All(n => n > 50)).Count() == 0;
        //    Console.WriteLine(resu);
        //}
    }


}
