using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnonymousTypeLINQ
{
    class Student
    {
        public int RollNo;
        public string Name;
        public string Batch;
        public int Age;
    }
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> student = new List<Student>
            {
                new Student { RollNo = 12, Name = "Shilpi", Batch = "CO-4", Age = 22},
                new Student { RollNo = 21, Name = "Ankit", Batch = "CO-5", Age = 24},
            };

            var st = from stud in student
                     select new { stud.RollNo, stud.Name, stud.Batch};

            foreach (var i in st)
            {
                Console.WriteLine("Student Roll = " +i.RollNo + "\nStudent Name = " +i.Name + "\nStudent Batch = " +i.Batch);
                Console.WriteLine();
            }
        }
    }
}
