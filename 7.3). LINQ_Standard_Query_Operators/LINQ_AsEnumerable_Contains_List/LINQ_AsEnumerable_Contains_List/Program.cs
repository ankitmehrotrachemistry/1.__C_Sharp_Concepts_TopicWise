using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_AsEnumerable_Contains_List
{
    public class Employee
    {
        public int ID;
        public string Name;
        public int Salary;
        public string Department;
    }
    class Program
    {
        static void Main(string[] args)
        {
            bool isExist = false;

            List<Employee> employeeList = new List<Employee>()
            {
                new Employee {ID = 101, Name = "Ankit", Salary = 120000, Department = "CSE"},
                new Employee {ID = 102, Name = "Amit", Salary = 140000, Department = "IT"},
                new Employee {ID = 103, Name = "Akhil", Salary = 180000, Department = "Mech"},
                new Employee {ID = 104, Name = "Ayush", Salary = 100000, Department = "Civil"},
                new Employee {ID = 105, Name = "Shubham", Salary = 880000, Department = "Electrical"},
            };

            Employee Emp1 = new Employee() {ID = 102, Name = "Amit", Salary = 140000, Department = "IT"};

            isExist = employeeList.AsEnumerable().Contains(Emp1);

            if (isExist == true)
                Console.WriteLine("Emp1 is present");
            else
                Console.WriteLine("Emp1 not present");
        }
    }
}
