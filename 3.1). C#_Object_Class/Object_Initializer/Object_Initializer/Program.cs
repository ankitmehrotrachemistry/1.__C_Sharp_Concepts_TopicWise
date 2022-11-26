using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Object_Initializer
{
    public class Student
    {
        public int StudentId { get; set; }
        public string StudentName { get; set; }
        public int Age { get; set; }
        public string Address { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Student std = new Student() { 
                                            StudentId = 1,
                                            StudentName = "Ankit",
                                            Age = 28,
                                            Address = "Buxar"
                                        };
            Console.WriteLine(std.StudentId);
            Console.WriteLine(std.StudentName);
            Console.WriteLine(std.Age);
            Console.WriteLine(std.Address);
        }
    }
}
