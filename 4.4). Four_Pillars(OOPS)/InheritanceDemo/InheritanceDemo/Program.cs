using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceDemo
{
    class Person
    {
        public string _name;
        public string _surname;
        public int _age;

        public void PersonData(string name, string surname, int age)
        {
            _name = name;
            _surname = surname;
            _age = age;
        }

        public void PersonDataWriter()
        {
            Console.WriteLine("Name is : " + _name);
            Console.WriteLine("Surname is " + _surname);
            Console.WriteLine("Age is " + _age);
        }
    }

    class Student : Person
    {
        float _studentGrade;
        int _classYear;
        int _studentNumber;
        public void StudentData(float studentGrade, int classYear, int studentNumber)
        {
            _studentGrade = studentGrade;
            _classYear = classYear;
            _studentNumber = studentNumber;
        }
        public void StudentDataWriter()
        {
            Console.WriteLine("Name: " + _name);
            Console.WriteLine("Surname: " + _surname);
            Console.WriteLine("Age: " + _age);
            Console.WriteLine("Student Grade: " + _studentGrade);
            Console.WriteLine("Class Year: " + _classYear);
            Console.WriteLine("Student Number: " + _studentNumber);

        }
    }
    class Teacher : Person
    {
        int teacherNumber;
        string department;
    }
    class Program
    {
        static void Main(string[] args)
        {
            var obj = new Student();

            obj.PersonData("Ankit", "Mehrotra", 28);
            obj.StudentData(7.2f, 4, 1120580);

            Console.WriteLine("Student Class Writer \n ------------");
            obj.StudentDataWriter();

            Console.WriteLine("\nPerson Class Writer:\n--------------------");
            obj.PersonDataWriter();

        }
    }
}
