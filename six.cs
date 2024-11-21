using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq_Assignment
{
    using System;
    using System.Collections.Generic;

    public class Student
    {
        public int StudentID { get; set; }
        public string Name { get; set; }
        public List<string> Courses { get; set; }  
    }

    class six
    {
        //static void Main()
        //{

        //    var students = new List<Student>
        //    {
        //        new Student
        //        {
        //            StudentID = 1,
        //            Name = "Alice",
        //            Courses = new List<string> { "Math", "Science", "History", "Art" }
        //        },
        //        new Student
        //        {
        //            StudentID = 2,
        //            Name = "Bob",
        //            Courses = new List<string> { "Math", "Science", "English" }
        //        },
        //        new Student
        //        {
        //            StudentID = 3,
        //            Name = "Charlie",
        //            Courses = new List<string> { "Math", "History", "Chemistry", "Physics", "Biology" }
        //        },
        //        new Student
        //        {
        //            StudentID = 4,
        //            Name = "David",
        //            Courses = new List<string> { "Math", "Science" }
        //        },
        //        new Student
        //        {
        //            StudentID = 5,
        //            Name = "Eve",
        //            Courses = new List<string> { "Art", "History", "English", "Psychology", "Sociology" }
        //        }
        //    };

        //    var res = students.Where(s => s.Courses.Count() > 3);

        //    //or

        //    var resi = students.Where(s => s.Courses.Any(c => s.Courses.Count>3));



        //    foreach (var i in res)
        //    {
        //        Console.WriteLine($" {i.Name}    and   StudentID : {i.StudentID} ");
        //    }

        //    foreach (var s in resi)
        //    {
        //        Console.WriteLine(s.Name);
        //    }





        //}
    }

}
