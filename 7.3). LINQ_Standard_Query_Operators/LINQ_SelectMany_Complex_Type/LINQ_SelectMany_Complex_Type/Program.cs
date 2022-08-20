using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_SelectMany_Complex_Type
{
    public class Student
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public List<string> Programming { get; set; }
        public static List<Student> GetStudents()
        {
            return new List<Student>()
            {
                new Student() { ID = 1, Name = "Ankit", Email = "ankitmehrotrachemistry@gmail.com", Programming = new List<string>() { "C#", "Java", "C++" } },
                new Student() { ID = 2, Name = "Sunny", Email = "sunnykumar@gmail.com", Programming = new List<string>() { "WCF", "SQL Server", "C#" } },
                new Student() { ID = 3, Name = "Prateek", Email = "prateekpandey@gmail.com", Programming = new List<string>() { "MVC", "Java", "LINQ" } },
                new Student() { ID = 4, Name = "Zebrat", Email = "zebratkushwaha@gmail.com", Programming = new List<string>() { "ADO.NET", "C#", "LINQ" } }
            };
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            List<string> linqStudentSyntax = Student.GetStudents().SelectMany(x => x.Programming).ToList();

            IEnumerable<string> QuerySyntax = from std in Student.GetStudents()
                                              from program in std.Programming
                                              select program;

            foreach (string program in linqStudentSyntax)
            {
                Console.WriteLine(program);
            }
        }
    }
}