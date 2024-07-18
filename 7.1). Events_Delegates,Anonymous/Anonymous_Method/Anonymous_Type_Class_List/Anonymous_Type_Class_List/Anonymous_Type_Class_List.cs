using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anonymous_Type_Class_List
{
    public class Student
    {
        public int StudentId { get; set; }
        public string StudentName { get; set; }
        public int Age { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            IList<Student> studentList = new List<Student>()
            {
                new Student() { StudentId = 1, StudentName = "John", Age = 18 } ,
                new Student() { StudentId = 2, StudentName = "Steve",  Age = 21 } ,
                new Student() { StudentId = 3, StudentName = "Bill",  Age = 18 } ,
                new Student() { StudentId = 4, StudentName = "Ram" , Age = 20  }
            };

            var students = from s in studentList
                           select new { Id = s.StudentId, Name = s.StudentName, Age = s.Age };

            foreach (var stud in students)
                Console.WriteLine(stud.Id + "-" + stud.Name + ", " + stud.Age);
        }
    }
}