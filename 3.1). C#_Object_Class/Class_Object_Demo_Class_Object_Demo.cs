using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Object_Demo
{
    class Student
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public Student(string name, int age)
        {
            Name = name;
            Age = age;
        }
        public void GetStudentDetails()
        {
            Console.WriteLine("Name : {0}, Age : {1}", Name, Age);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Student stud = new Student("Ankit", 14);
            stud.GetStudentDetails();
        }
    }
}