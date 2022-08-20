using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_From_Where_Select_List
{
    public class Student
    {
        public string StudentName { get; set; }
        public int StudentScore { get; set; }
        public int Age { get; set; }
        
    }
    class Program
    {
        static void Main(string[] args)
        {
           IList<Student> studentList = new List<Student>() {
           new Student() { StudentName = "Steve", StudentScore = 100, Age = 28},
           new Student() { StudentName = "Happy", StudentScore = 80, Age = 24},
           new Student() { StudentName = "Akki", StudentScore = 40, Age = 18},
           new Student() { StudentName = "Vijay", StudentScore = 140, Age = 34},
           new Student() { StudentName = "Briker", StudentScore = 240, Age = 40}
           };

            var ageRangeStudent = from s in studentList
                                  where s.Age > 16 && s.Age < 28
                                  select s;

            foreach (Student smallStud in ageRangeStudent)
                Console.WriteLine("Student Name is : {0}", smallStud.StudentName);
        }
    }
}
