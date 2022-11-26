using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Copy_Constructor_Demo
{
    class Employee
    {
        public string name, designation;
        public int salary;
        public Employee(string _name, string _designation, int _salary)
        {
            name = _name;
            designation = _designation;
            salary = _salary;
        }
        // Copy Constructor
        public Employee(Employee emp)
        {
            name = emp.name;
            designation = emp.designation;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Employee empObj1 = new Employee("Ankit Mehrotra", "Game Developer", 80000);
            Employee empObj2 = new Employee(empObj1); // Copy COnstructor

            empObj2.name = "Akhil Kumar";
            empObj2.designation = "Software Developer";
            empObj2.salary = 100000;

            Console.WriteLine("Defaut Constructor : " + empObj1.name + " , " + empObj1.designation + " , " +empObj1.salary);
            Console.WriteLine("Copy Constructor : " +empObj2.name + " , " +empObj2.designation + " , " +empObj2.salary);
        }
    }
}
