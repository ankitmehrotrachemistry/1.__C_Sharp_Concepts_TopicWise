using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Object_Initializer_Constructor
{
    class Employee
    {
        public string FirstName { get; set; }
        public int Age { get; set; }
        public double Salary { get; set; }
        public Employee()
        {
        }
        public Employee(string firstName, int age, double salary)
        {
            FirstName = firstName;
            Age = age;
            Salary = salary;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Employee emp = new Employee()
            {
                FirstName = "Ankit",
                Age = 28,
                Salary = 84418.70
            };
            Console.WriteLine("{0} is {1} years old and earns {2} per year", emp.FirstName, emp.Age.ToString(), emp.Salary.ToString());
            Employee emp1 = new Employee("Tinna", 24, 64875.50);
            Console.WriteLine("{0} is {1} years old and earns £{2} per year.", emp1.FirstName, emp1.Age.ToString(), emp1.Salary.ToString());
        }
    }
}