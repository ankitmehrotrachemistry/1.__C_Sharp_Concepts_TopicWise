using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_Sum
{
    public class Student
    {
        public int StudentID { get; set; }
        public string StudentName { get; set; }
        public int Age { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            IList<Student> studentList = new List<Student>()
            {
                new Student() { StudentID = 1, StudentName = "Ankit", Age = 10},
                new Student() { StudentID = 2, StudentName = "Ankush", Age = 20},
                new Student() { StudentID = 3, StudentName = "Akki", Age = 30},
                new Student() { StudentID = 4, StudentName = "Vicky", Age = 40}
            };

            var ageSum = studentList.Sum(s => s.Age);

            Console.WriteLine("Sum of all Student age is : {0}", ageSum);

            var totalAdults = studentList.Sum(s => {
                if (s.Age >= 18)
                    return 1;
                else
                    return 0;
                });

            Console.WriteLine("Total Number of Adult Students are : {0}", totalAdults);
        }
    }
}
