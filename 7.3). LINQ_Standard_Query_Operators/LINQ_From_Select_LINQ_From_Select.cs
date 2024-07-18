using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_From_Select
{
    public class Student 
    { 
        public int StudentID { get; set; }
        public string StudentName { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            IList<Student> studentList = new List<Student>()
            {
                new Student() { StudentID = 1, StudentName = "Ankit"},
                new Student() { StudentID = 2, StudentName = "Rishi"},
                new Student() { StudentID = 3, StudentName = "Chaaya"},
                new Student() { StudentID = 4, StudentName = "Vandana"},
                new Student() { StudentID = 5, StudentName = "Atul"}
            };

            var selectResult = from s in studentList
                               select s.StudentName;

            foreach(var name in selectResult)
            {
                Console.WriteLine(name);
            }
        }
    }
}