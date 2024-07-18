using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Object_Initializer_List
{
    public class Student
    {
        public int StudentId { get; set; }
        public string StudentName { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            IList<Student> studentList = new List<Student>()
            {
                new Student() { StudentId = 1, StudentName = "A"},
                new Student() { StudentId = 2, StudentName = "B"},
                new Student() { StudentId = 3, StudentName = "C"},
                new Student() { StudentId = 4, StudentName = "D"},
                new Student() { StudentId = 5, StudentName = "E"}
            };

            Console.WriteLine("Total Students are : {0}", studentList.Count);
            Console.WriteLine("Student Name is : ", studentList[0].StudentName);
            Console.WriteLine("ID is : " , studentList[1].StudentId);
        }
    }
}
